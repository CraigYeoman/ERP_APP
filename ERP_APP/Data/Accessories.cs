using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Data
{
    public class Accessories : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<WorkOrderAccessories>? WorkOrderAccessories { get; set; }
    }
}
