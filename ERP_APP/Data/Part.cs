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
        public int VendorID { get; set; }

        public int CustomerPrice { get; set; }
        public int CostOfGood { get; set; }
        public string? PartNumber { get; set; }
        public string? Manufacturer { get; set; }
        [ForeignKey("PartCategoryId")]
        public PartCategory? PartCategory { get; set; }
        public int PartCategoryID { get; set; }
        public ICollection<WorkOrderPart>? WorkOrderParts { get; set; }
    }
}
