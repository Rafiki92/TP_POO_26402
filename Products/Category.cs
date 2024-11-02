using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;

namespace ThriftShop.Products
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        #region Attributes
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private static List<Category> categories = new List<Category>();

        #endregion

        #region Construtors
        public Category(int categoryId, string name, string description)
        {
            this.CategoryId = categoryId;
            this.Name = name;
            this.Description = description;
        }
        #endregion

        #region Methods
        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public static void DisplayCategories()
        {
            Console.WriteLine("Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}, Name: {category.Name}, Description: {category.Description}");
            }
        }
        #endregion
    }
}
