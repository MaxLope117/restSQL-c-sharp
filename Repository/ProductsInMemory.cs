using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using restSQL.Models;
namespace restSQL.Respository;

public class ProductsInMemory
{
  private readonly List<Product> products =
  [
    new Product { Id = 1, Name = "Martillo", Description = "Martillo ultra duro", Precio = 12.99, createdAt = DateTime.Now },
    new Product { Id = 2, Name = "Caja de clavos", Description = "100 unidades", Precio = 4.99, createdAt = DateTime.Now },
    new Product { Id = 3, Name = "Destornillador", Description = "De cruz", Precio = 7.99, createdAt = DateTime.Now },
    new Product { Id = 4, Name = "Foco", Description = "Luz amarilla", Precio = 2.99, createdAt = DateTime.Now },
  ];

  public IEnumerable<Product> GetProducts()
  {
    return products;
  }

  public Product GetProductById(int id)
  {
    var product = products.SingleOrDefault(product => product.Id == id);
    // products.Where(product => product.Id == id).SingleOrDefault();
    if (product == null)
    {
      return NotFound();
    }

    return product;
  }
}
