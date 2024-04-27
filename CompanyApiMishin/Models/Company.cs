namespace CompanyApiMishin.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Motherland { get; set; }
        public int OfficesCount { get; set; }
        public System.DateTime FoundationDate { get; set; }
    }
}
