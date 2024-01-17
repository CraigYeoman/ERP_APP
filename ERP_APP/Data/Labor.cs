using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Data
{
    public class Labor : BaseEntity
    {
        public string? Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [ForeignKey("LaborCategoryId")]
        public LaborCategory? LaborCategory { get; set; }
        public int LaborCategoryId { get; set; }
        public ICollection<WorkOrderLabor>? WorkOrderLabor { get; set;}
    }
}
