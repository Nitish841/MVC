// ----------------------------------------------------------------------
// File: Category.cs
// Description: Define the category class for managing category
// Author: Nitish Kumar
// Created: January 6, 2025
// ----------------------------------------------------------------------

namespace Practice.Models
{
    /// <summary>
    /// Represent a category with identifier, name and display order
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order of the category
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
