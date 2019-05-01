using BlazorVirtualScrolling;
using Microsoft.JSInterop;

public class VirtualScrollJsHelper
{
    private readonly IVirtualScroll _host;

    public VirtualScrollJsHelper(IVirtualScroll host)
    {
        _host = host;
    }

    [JSInvokable]
    public void VirtualScrollingSetView(ScrollView view)
    {
        _host.VirtualScrollingSetView(view);
    }
}

public interface IVirtualScroll
{
    void VirtualScrollingSetView(ScrollView view);
}