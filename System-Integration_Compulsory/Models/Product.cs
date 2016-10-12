
using System.ComponentModel.DataAnnotations;

namespace System_Integration_Compulsory.Models
{
    public class Product
    {
        [Required]
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public long NumberInStock { get; set; }
    }
}