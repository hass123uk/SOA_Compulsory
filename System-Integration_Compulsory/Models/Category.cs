using System.ComponentModel.DataAnnotations;

namespace System_Integration_Compulsory.Models
{
    /// <summary>
    /// Category of products
    /// </summary>
    public class Category
    {
        /// <summary>
        /// The unique identifier Type: Long
        /// </summary>
        [Required]
        public long Id { get; set; }
        /// <summary>
        /// The category name
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}