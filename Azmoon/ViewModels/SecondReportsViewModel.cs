namespace Azmoon.ViewModels
{
    public class SecondReportsViewModel
    {
        public SecondReportsViewModel()
        {
            selectedColumns = new List<string>();
        }
        public string? Title { get; set; }
        public List<string> selectedColumns { get; set; }
    }
}
