
using System.ComponentModel.DataAnnotations;

namespace System_Integration_Compulsory.Models
{
    /// <summary>
    /// Product Attributes 
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The unique identifier; Type: Long
        /// </summary>
        [Required]
        [DataType("Long")]
        public long Id { get; set; }
        /// <summary>
        /// The name of the product
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The Price for one item of the product
        /// </summary>
        [Required]
        public decimal Price { get; set; }
        /// <summary>
        /// In which category the product belongs
        /// </summary>
        [Required]
        public Category Category { get; set; }
        /// <summary>
        /// How many items there are in stock
        /// </summary>
        [Required]
        public long NumberInStock { get; set; }
    }
}