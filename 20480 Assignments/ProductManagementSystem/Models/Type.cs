using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class Type
    {
        [Key]
        public int TypeID { get; set; }

        public string TypeName { get; set; }

        public virtual ICollection<Tea> Teas { get; set; }
    }
}
