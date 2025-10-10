using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private readonly List<ProductCategory> productCategories;
    
    public ProductCategoryRepository()
    {
        productCategories =
        [
            new ProductCategory(1, "Bakkerij",3,2),
            new ProductCategory(2,"Zuivel",1,3),
            new ProductCategory(3, "Melk",2,3),
            new ProductCategory(4,"Ontbijt", 4, 4)
        ];
    }

    public List<ProductCategory> GetAll()
    {
        return productCategories;
    }

    public ProductCategory? Get(int id)
    {
        return productCategories.FirstOrDefault(x => x.Id == id);
    }
}