
using System.ComponentModel.DataAnnotations;

namespace System_Integration_Compulsory.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public long Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long NumberInStock { get; set; }
    }
}