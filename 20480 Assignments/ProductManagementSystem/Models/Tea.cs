using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class Tea
    {
        [Display(Name = "TeaID")]
        [Required(ErrorMessage = "This field must be filled")]
        public int Id { get; set; }
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
    }
}
