using System.Collections;
namespace DemoPracticeMediatr.Data;


public class MockProducts
{
    private readonly List<Product> products;

    public MockProducts()
    {

        products = new List<Product>
        {
            new Product { Id = 1, Name = "Test Product 1" },
            new Product { Id = 2, Name = "Test Product 2" },
            new Product { Id = 3, Name = "Test Product 3" }
        };
    }

    public async Task AddProduct(Product product)
    {
        products.Add(product);
        await Task.CompletedTask;
    }
    public async Task<IEnumerable<Product>> GetAllProducts()
    {

        return await Task.FromResult(products);
    }

    public async Task<Product> GetProductById(int id)
    {

        return await Task.FromResult(products.Single(x => x.Id == id));
    }
}