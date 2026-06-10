using BloomBeauty.Models;

namespace BloomBeauty.Services;

public class ProductService
{
    private List<Product> products = new()
    {
        new Product 
        { 
            Id = 1, 
            Name = "SKIN1004 Madagascar Centella 27g", 
            Price = 475, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1389_713x.png?v=1731800604",
            Category = "Skincare",
            Rating = 4.8
        },
        new Product 
        { 
            Id = 2, 
            Name = "TIRTIR Mask Fit Make Up Fixer 80ml", 
            Price = 495, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1387_713x.png?v=1731800400",
            Category = "Maquillaje",
            Rating = 4.9
        },
        new Product 
        { 
            Id = 3, 
            Name = "TIRTIR Mask Fit Red Cushion 4.5g", 
            Price = 435, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1386_713x.png?v=1731800327",
            Category = "Maquillaje",
            Rating = 4.7
        },
        new Product 
        { 
            Id = 4, 
            Name = "TIRTIR Milk Skin Toner Light 150ml", 
            Price = 640, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1392_360x.png?v=1731800353",
            Category = "Skincare",
            Rating = 4.6
        },
        new Product 
        { 
            Id = 5, 
            Name = "Skin1004 Madagascar Centella Light Cleansing Oil 200ml", 
            Price = 530, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1126_713x.png?v=1714248783",
            Category = "Skincare",
            Rating = 4.8
        },
        new Product 
        { 
            Id = 6, 
            Name = "Elizavecca Hair Muscle Essence Oil (CER-100) 100ml", 
            Price = 435, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1013_360x.png?v=1702865667",
            Category = "Cabello",
            Rating = 4.5
        },
        new Product 
        { 
            Id = 7, 
            Name = "ROM&ND X INAPSQUARE Better Than Eyes #B02 Peony in Black", 
            Price = 340, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1320_713x.png?v=1723932894",
            Category = "Maquillaje",
            Rating = 4.9
        },
        new Product 
        { 
            Id = 8, 
            Name = "ROM&ND Tinte de labios Juicy Lasting Tint 5.5g", 
            Price = 295, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1210_0074565a-b900-42c7-a6f5-e4962580e845_360x.png?v=1717201844",
            Category = "Maquillaje",
            Rating = 4.8
        },
        new Product 
        { 
            Id = 9, 
            Name = "Anua-Hearleaf Pore Control Cleansing Oil 200ml", 
            Price = 650, 
            ImageUrl = "https://makokm.com/cdn/shop/files/838_713x.png?v=1693079281",
            Category = "Skincare",
            Rating = 4.7
        },
        new Product 
        { 
            Id = 10, 
            Name = "Fwee Lip & Cheek Blurry Pudding Pot Con", 
            Price = 500, 
            ImageUrl = "https://makokm.com/cdn/shop/files/1384_713x.png?v=1728950702",
            Category = "Maquillaje",
            Rating = 4.6
        },
        new Product 
        { 
            Id = 11, 
            Name = "TOCOBO Cotton Soft Sun Stick SPF50+ PA++++", 
            Price = 495, 
            ImageUrl = "https://makokm.com/cdn/shop/files/804_713x.png?v=1693088264",
            Category = "Skincare",
            Rating = 4.8
        },
        new Product 
        { 
            Id = 12, 
            Name = "ROM&ND Han All Fix Mascara | #V01 Volume Black", 
            Price = 315, 
            ImageUrl = "https://makokm.com/cdn/shop/files/813_713x.png?v=1693006678",
            Category = "Maquillaje",
            Rating = 4.9
        }
    };

    public List<Product> GetNewProducts()
    {
        return products.Take(8).ToList();
    }

    public List<Product> GetViralProducts()
    {
        return products.Skip(8).Take(4).ToList();
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    public List<Product> SearchProducts(string query)
    {
        return products
            .Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public Product GetProductById(int id)
    {
        return products.FirstOrDefault(p => p.Id == id);
    }
}
