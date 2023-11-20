using Models.Product;

public class MemoryProductService : IProductService
{
    private readonly Dictionary<int, Product> _items = new Dictionary<int, Product>()
    {
         {1, new Product() { Id = 1, Name = "Apap", Producer = "SomeProducer", Price = 10.99m, ProductionDate = DateTime.Now, Description = "Some description" } }
    };

    public void Add(Product product)
    {
        product.Id = product.Id + 1;
        _items[product.Id] = product;
    }

    public List<Product> FindAll()
    {
        return _items.Values.ToList();
    }

    public Product? FindById(int id)
    {
        return _items[id];
    }

    public void RemoveById(int id)
    {
        _items?.Remove(id);
    }

    public void Update(Product product)
    {
        _items[product.Id] = product;
    }

}
