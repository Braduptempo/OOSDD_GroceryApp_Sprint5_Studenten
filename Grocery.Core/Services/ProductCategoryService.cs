using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IProductCategoryRepository _productCategoryRepository;
    
    public List<ProductCategory> GetAll()
    {
        return _productCategoryRepository.GetAll();
    }

    public ProductCategory? Get(int id)
    {
        return _productCategoryRepository.Get(id);
    }
}