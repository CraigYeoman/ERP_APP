using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Data
{
    public class Labor : BaseEntity
    {
        public string? Name { get; set; }
        public int Price { get; set; }

        [ForeignKey("LaborCategoryId")]
        public LaborCategory? LaborCategory { get; set; }
        public int LaborCategoryId { get; set; }
        public ICollection<WorkOrderLabor>? WorkOrderLabor { get; set;}
    }
}
