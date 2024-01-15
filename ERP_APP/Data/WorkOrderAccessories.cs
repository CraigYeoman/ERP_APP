namespace ERP_APP.Data
{
    public class WorkOrderAccessories
    {
        public int WorkOrderId { get; set; }
        public int AccessoriesId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
        public Accessories? Accessories { get; set; }
    }
}
