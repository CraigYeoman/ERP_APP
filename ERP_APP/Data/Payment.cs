using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Data
{
    public class Payment : BaseEntity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Deposit { get; set; }
        public int WorkOrderId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
    }
}
