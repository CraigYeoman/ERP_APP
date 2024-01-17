using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Data
{
    public class Part : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey("VendorId")]
        public Vendor? Vendor { get; set; }
        public int VendorId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CustomerPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostOfGood { get; set; }
        public string? PartNumber { get; set; }
        public string? Manufacturer { get; set; }
        [ForeignKey("PartCategoryId")]
        public PartCategory? PartCategory { get; set; }
        public int PartCategoryId { get; set; }
        public ICollection<WorkOrderPart>? WorkOrderParts { get; set; }
        
    }
}
