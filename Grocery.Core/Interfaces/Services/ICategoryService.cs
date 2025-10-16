using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services;

public interface ICategoryService
{
    public List<Category> GetAll();
    
    public Category? Get(int id);
}