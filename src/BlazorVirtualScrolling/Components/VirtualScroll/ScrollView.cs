namespace BlazorVirtualScrolling
{
    public class ScrollView
    {
        public int ClientHeight { get; set; }

        public int ScrollTop { get; set; }
    }

    public class ScrollViewResult
    {
        public int Height { get; set; }
        public int SkipItems { get; set; }
        public int TakeItems { get; set; }
    }
}