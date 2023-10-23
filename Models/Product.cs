using System.ComponentModel.DataAnnotations;

namespace ProductModelClassAssignment3.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public int Price { get; set; }
        [Required]

        public int Cid { get; set; }
        [Required]

        public string? ImageUrl { get; set; }

        public int IsActive { get; set; }
    }
}
