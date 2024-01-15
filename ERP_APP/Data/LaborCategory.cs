namespace ERP_APP.Data
{
    public class LaborCategory : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Labor>? Labors { get; set; }
    }
}
