namespace ERP_APP.Data
{
    public class JobType : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<WorkOrder>? WorkOrders { get; set; }
    }
}
