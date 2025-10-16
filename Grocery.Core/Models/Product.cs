using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        public int stock;
        
        [ObservableProperty]
        public double price;
        public DateOnly ShelfLife { get; set; }
        public Product(int id, string name, int stock)
            : this(id, name, stock, default,0.00) { }
        
        public Product(int id, string name, int stock, DateOnly shelfLife) 
            : this(id, name, stock, shelfLife, 0.00) { }

        public Product(int id, string name, int stock, DateOnly shelfLife, double price)
            : base(id, name) 
        {
            Stock = stock;
            ShelfLife = shelfLife;
            Price = price;
        }
        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad - €{Price:F2}";
        }
    }
}
