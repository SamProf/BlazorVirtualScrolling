using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorVirtualScrolling
{
    public class BaseVirtualScroll<ItemType> : ComponentBase
    {
        [Parameter]
        public string Class { get; set; }

        [Parameter]
        public string Style { get; set; }

        [Parameter]
        public int RowHeight { get; set; } = 50;

        public ElementRef Ref { get; set; }

        [Parameter]
        public RenderFragment<ItemType> ChildContent { get; set; }

        [Parameter]
        public IEnumerable<ItemType> Items { get; set; }
    }
}