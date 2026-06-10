using BloomBeauty.Models;

namespace BloomBeauty.Services;

public class CartService
{
    private List<Product> cartItems = new();

    public event Action OnCartChanged;

    public void AddToCart(Product product)
    {
        var existingItem = cartItems.FirstOrDefault(p => p.Id == product.Id);
        
        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            var item = new Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Quantity = 1
            };
            cartItems.Add(item);
        }
        
        OnCartChanged?.Invoke();
    }

    public void RemoveFromCart(int productId)
    {
        var item = cartItems.FirstOrDefault(p => p.Id == productId);
        if (item != null)
        {
            cartItems.Remove(item);
            OnCartChanged?.Invoke();
        }
    }

    public void UpdateQuantity(int productId, int quantity)
    {
        var item = cartItems.FirstOrDefault(p => p.Id == productId);
        if (item != null)
        {
            item.Quantity = quantity;
            if (item.Quantity <= 0)
            {
                RemoveFromCart(productId);
            }
            OnCartChanged?.Invoke();
        }
    }

    public List<Product> GetCartItems()
    {
        return cartItems;
    }

    public int GetCartCount()
    {
        return cartItems.Sum(p => p.Quantity);
    }

    public decimal GetCartTotal()
    {
        return cartItems.Sum(p => p.Price * p.Quantity);
    }

    public void ClearCart()
    {
        cartItems.Clear();
        OnCartChanged?.Invoke();
    }
}
