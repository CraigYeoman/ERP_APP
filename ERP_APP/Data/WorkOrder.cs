using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace ERP_APP.Data
{
    public class WorkOrder : BaseEntity
    {
        
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
       
        [ForeignKey("JobTypeId")]
        public JobType? JobType { get; set; }
        public int JobTypeId { get; set; }

        public DateTime DueDate { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime DateFinished { get; set; }
        public bool Complete { get; set; }
        public int WorkOrderNumber { get; set; }
        public string? Notes { get; set; }
        public ICollection<WorkOrderPart>? WorkOrderParts { get; set; }
        public ICollection<WorkOrderLabor>? WorkOrderLabors { get; set; }
        public ICollection<WorkOrderAccessories>? WorkOrderAccessories { get; set; }
        public ICollection<Payment>? Payments { get; set; }

    }
}
