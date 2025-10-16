using Grocery.Core.Data.Repositories;
using Grocery.Core.Models;
using Grocery.Core.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.App.ViewModels;

[QueryProperty(nameof(Category), "Category")]
public partial class ProductCategoryViewModel
{
    private readonly ProductCategoryRepository _productCategoryRepository;
    private readonly ProductCategoryService _productCategoryService;
    private Category? _category;
    public Category? Category
    {
        get => _category;
        set
        {
            _category = value;
            LoadProducts();
        }
    }

    public ObservableCollection<ProductCategory> Products { get; set; } = new();

    public ProductCategoryViewModel(
        ProductCategoryRepository productCategoryRepository,
        ProductCategoryService productCategoryService)
    {
        _productCategoryRepository = productCategoryRepository;
        _productCategoryService = productCategoryService;
        LoadProducts();
    }

    private void LoadProducts()
    {
        if (Category == null)
            return;

        var list = _productCategoryRepository
            .GetAll()
            .Where(p => p.CategoryId == Category.Id)
            .ToList();

        Products = new ObservableCollection<ProductCategory>(list);
    }
}