namespace ERP_APP.Data
{
    public class WorkOrderAccessories : BaseEntity
    {
        public int WorkOrderId { get; set; }
        public int AccessoriesId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
        public Accessories? Accessories { get; set; }
    }
}
