using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface ICategoryRepository
{
    public List<Category> GetAll();
    
    public Category? Get(int id);
}