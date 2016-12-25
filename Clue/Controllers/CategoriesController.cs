using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clue.Models;

namespace Clue.Controllers
{
    class CategoriesController
    {
        private GameMemory _context;

        public CategoriesController()
        {
            _context = new GameMemory();
        }

        public ICollection<Category> GetCategory()
        {
            return _context.Categories;
        }

        public Category GetCategory(int Id)
        {
            Category category = _context.Categories.First(c => c.Id == Id);
            return category;
        }

        public Category UpdateCategory(int Id, Category category)
        {
            Category SaveCategory = _context.Categories.First(c => c.Id == Id);
            SaveCategory = category;
            return SaveCategory;
        }

        public Category CreateCategory(Category category)
        {
            category.Id = _context.Categories.Count() + 1;
            _context.Categories.Add(category);

            return category;
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
        }
    }
}
