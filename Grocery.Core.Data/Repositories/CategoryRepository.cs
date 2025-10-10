using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> categories;
    
    public CategoryRepository()
    {
        categories =
            [
                new Category(1, "Groente"),
                new Category(2, "Bakkerij"),
                new Category(3, "Zuivel"),
                new Category(4, "Ontijt")
            ]
            ;
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category? Get(int id)
    {
        return categories.FirstOrDefault(x => x.Id == id);
    }
}