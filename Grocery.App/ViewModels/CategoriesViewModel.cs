using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.App.Views;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public partial class CategoriesViewModel
{
    private readonly ICategoryService _categoryService;
    private readonly ICategoryRepository _categoryRepository;
    public ProductCategoryViewModel ProductCategoryViewModel { get; set; }
    
    
    public ObservableCollection<Category> Categories { get; set; }

    public CategoriesViewModel(
        ICategoryService categoryService,
        ICategoryRepository categoryRepository)
    {
        _categoryService = categoryService;
        _categoryRepository = categoryRepository;
        
        // Vul de collectie meteen met data (NB: null-veilig)
        var list = _categoryRepository?.GetAll() ?? [];
        Categories = new ObservableCollection<Category>(list);
    }

    [RelayCommand]
    private async Task CategorySelected(Category? selectedCategory)
    {
        if (selectedCategory == null)
        {
            await Shell.Current.DisplayAlert("Debug", "Geen categorie geselecteerd!", "OK");
            return;
        }
        
        await Shell.Current.DisplayAlert("Debug", $"Categorie: {selectedCategory.Name}", "OK");

        var parameters = new Dictionary<string, object?>
        {
            { "Category", selectedCategory }
        };
        
        await Application.Current?.MainPage?.Navigation.PushAsync(new ProductCategoryView(ProductCategoryViewModel))!;

    }

}