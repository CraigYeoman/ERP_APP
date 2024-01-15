namespace ERP_APP.Data
{
    public class Vendor : BaseEntity
    {
        public string? Name { get; set; }
        public string? MainContact { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? CustomerNumber { get; set; }
        public ICollection<Part>?Parts { get; set; }
    }
}
