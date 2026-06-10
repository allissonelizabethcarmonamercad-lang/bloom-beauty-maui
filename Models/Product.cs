namespace BloomBeauty.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string Category { get; set; }
    public bool IsFavorite { get; set; }
    public int Quantity { get; set; } = 1;
    public double Rating { get; set; }
}
