using DataAccess.services;
using DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class CategoryRepository : ICategoryRepository
    {
        /*** DB Context  */
        public RestaurantContext _dbContext { get; set; }
        /*** Cunstructor  */
        public CategoryRepository()
        {
            this._dbContext = new RestaurantContext();
        }

        public int Add(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category.CategoryID;
        }

        public Category Get(int id)
        {
            var categoryFounded = _dbContext.Categories.FirstOrDefault(cat => cat.CategoryID == id);

            return categoryFounded;
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.OrderByDescending(cat => cat.CategoryID).ToList();
        }

        public bool Remove(int categoryID)
        {

            try
            {
                var categoryFounded = _dbContext.Categories.FirstOrDefault(cat => cat.CategoryID == categoryID);
                _dbContext.Categories.Remove(categoryFounded);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Category newCategory)
        {
            try
            {
                var oldCategory = _dbContext.Categories.FirstOrDefault(
                    oldCat => oldCat.CategoryID == newCategory.CategoryID);
                oldCategory.CategoryName = newCategory.CategoryName;
                oldCategory.Description = newCategory.Description;
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool HasFood(int categoryID)
        {
            bool result = _dbContext.Foods.Any(x => x.CategoryID == categoryID);
            return result;
        }
    }
}
