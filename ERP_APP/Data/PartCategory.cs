namespace ERP_APP.Data
{
    public class PartCategory : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Part>? Parts { get; set; }
    }
}
