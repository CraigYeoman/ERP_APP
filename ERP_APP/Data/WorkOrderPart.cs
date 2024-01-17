namespace ERP_APP.Data
{
    public class WorkOrderPart : BaseEntity
    {
        public int WorkOrderId { get; set; }
        public int PartId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
        public Part? Part { get; set; }
    }
}
