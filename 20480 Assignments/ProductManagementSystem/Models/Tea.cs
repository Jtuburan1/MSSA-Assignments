using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementSystem.Models
{
    public enum Types
    {
        Black = 1,
        Green,
        White,
        Oolong,
        Puerh,
        Purple,
        Herbal
    }
    public class Tea
    {
        [Display(Name = "TeaID")]
        [Required(ErrorMessage = "This field must be filled")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int TypeID { get; set; } //Foreign Key

        [Display(Name = "Tea Name")]
        [Required]
        [AllLetters(ErrorMessage = "This field can only contain letters.")]
        public string? Name { get; set; }

        [Display(Name = "Tea Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        public string? Description { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public string? ImageName { get; set; }

        [Display(Name = "Type of Tea")]
        public Types TypeOfTea { get; set; }
    }
}
