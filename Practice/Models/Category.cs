// ----------------------------------------------------------------------
// File: Category.cs
// Description: Define the category class for managing category
// Author: Nitish Kumar
// Created: January 6, 2025
// ----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    /// <summary>
    /// Represent a category with identifier, name and display order
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category or Primary key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the category
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order of the category
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
