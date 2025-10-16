using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class CategorySevice : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public List<Category> GetAll()
    {
        return _categoryRepository.GetAll();
    }

    public Category? Get(int id)
    {
        return _categoryRepository.Get(id);
    }
}