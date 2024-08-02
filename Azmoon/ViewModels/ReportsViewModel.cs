namespace Azmoon.ViewModels
{
	public class ReportsViewModel
	{
		public ReportsViewModel()
		{
			Id = new();
			FirstName = new();
			LastName = new();
			PostalCode = new();
			Tel = new();
			Email = new();
			combinedList = new();
		}
		public List<int>? Id { get; set; }
		public List<string>? FirstName { get; set; }
		public List<string>? LastName { get; set; }
		public List<string>? PostalCode { get; set; }
		public List<string>? Tel { get; set; }
		public List<string>? Email { get; set; }
		public string? Title { get; set; }

		public List<string>? combinedList { get; set; }
	}
}
