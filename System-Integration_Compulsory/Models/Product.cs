
using System.ComponentModel.DataAnnotations;

namespace System_Integration_Compulsory.Models
{
    /// <summary>
    /// Product Attributes 
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The unique identifier
        /// </summary>
        [Required]
        public long Id { get; set; }
        /// <summary>
        /// The name of the product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Price for one item of the product
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// In which category the product belongs
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// The how many items there are in stock
        /// </summary>
        public long NumberInStock { get; set; }
    }
}