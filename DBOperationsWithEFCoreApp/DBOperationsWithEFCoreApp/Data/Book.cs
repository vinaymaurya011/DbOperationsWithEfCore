namespace DBOperationsWithEFCoreApp.Data
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NoOfPages { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public int Languageid { get; set; }

        public Language Language { get; set; }
    }
}
