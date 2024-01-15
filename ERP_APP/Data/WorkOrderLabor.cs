namespace ERP_APP.Data
{
    public class WorkOrderLabor
    {
        public int WorkOrderId { get; set; }
        public int LaborId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
        public Labor? Labor { get; set; }
    }
}
