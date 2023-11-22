using Laboratorium_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
public class MemoryProductService : IProductService
{
    private List<ProductModel> productList = new List<ProductModel>
    {
        new ProductModel { Id = 1, Name = "Product 1", Price = 10.99m, Producer = "Producer 1", ProductionDate = DateTime.Now, Description = "Product 1 description", Priority = Priority.Urgent },
        new ProductModel { Id = 2, Name = "Product 2", Price = 20.99m, Producer = "Producer 2", ProductionDate = DateTime.Now, Description = "Product 2 description", Priority = Priority.Urgent },
    };

    public IEnumerable<ProductModel> GetAllProducts()
    {
        return productList;
    }

    public ProductModel GetProductById(int productId)
    {
        return productList.FirstOrDefault(p => p.Id == productId);
    }

    public void AddProduct(ProductModel model)
    {
        model.Id = productList.Count + 1;
        productList.Add(model);
    }

    public void UpdateProduct(int productId, ProductModel updatedProduct)
    {
        var index = productList.FindIndex(p => p.Id == productId);

        if (index != -1)
        {
            updatedProduct.Id = productId;
            productList[index] = updatedProduct;
        }
    }

    public void DeleteProduct(int productId)
    {
        var productToRemove = productList.FirstOrDefault(p => p.Id == productId);

        if (productToRemove != null)
        {
            productList.Remove(productToRemove);
        }
    }
}