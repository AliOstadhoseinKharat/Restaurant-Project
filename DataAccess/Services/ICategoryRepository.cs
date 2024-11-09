using DomainModel.Models;
using System.Collections.Generic;

namespace DataAccess.services
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Get(int id);
        int Add(Category category);
        bool Remove(int categoryID);
        bool Update(Category category);

        bool HasFood(int categoryID);
    }
}
