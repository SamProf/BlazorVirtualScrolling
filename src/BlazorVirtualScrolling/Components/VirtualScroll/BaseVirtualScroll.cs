using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorVirtualScrolling
{
    public class BaseVirtualScroll<ItemType> : ComponentBase, IVirtualScroll
    {
        [Parameter]
        public string Class { get; set; }

        [Parameter]
        public string Style { get; set; }

        [Parameter]
        public int ItemHeight { get; set; } = 50;

        public ElementRef Ref { get; set; }

        [Parameter]
        public RenderFragment<ItemType> ChildContent { get; set; }

        [Parameter]
        public IEnumerable<ItemType> Items { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        private bool isFirstRender = true;

        protected override async Task OnAfterRenderAsync()
        {
            await base.OnAfterRenderAsync();
            if (isFirstRender)
            {
                this.JsHelper = new VirtualScrollJsHelper(this);
                var scrollView = await JsRuntime.InvokeAsync<ScrollView>("blazorVirtualScrolling.init", Ref, new DotNetObjectRef(JsHelper));
                this.SetScrollView(scrollView);
                isFirstRender = false;
            }
        }

        public VirtualScrollJsHelper JsHelper { get; set; }

        public void VirtualScrollingSetView(ScrollView scrollView)
        {
            this.SetScrollView(scrollView);
            
        }

        private void SetScrollView(ScrollView scrollView)
        {
            this.ScrollView = scrollView;
            this.ScrollViewResult = new ScrollViewResult();
            this.ScrollViewResult.Height = Items.Count() * ItemHeight;
            this.ScrollViewResult.SkipItems = scrollView.ScrollTop / this.ItemHeight;
            this.ScrollViewResult.TakeItems = (int)Math.Ceiling((double)(scrollView.ScrollTop + scrollView.ClientHeight) / (double)ItemHeight) - this.ScrollViewResult.SkipItems;
//            Console.WriteLine(ScrollViewResult.SkipItems + " " + ScrollViewResult.TakeItems);
            this.StateHasChanged();
        }

        public ScrollViewResult ScrollViewResult { get; set; }

        public ScrollView ScrollView { get; set; }
    }
}