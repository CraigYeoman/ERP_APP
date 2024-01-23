using ERP_APP.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Models
{
    public class LaborCreateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [ForeignKey("LaborCategoryId")]
        public LaborCategory? LaborCategory { get; set; }
        public int LaborCategoryId { get; set; }
    }
}
