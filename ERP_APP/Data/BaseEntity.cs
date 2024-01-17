using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_APP.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; }
    }
}
