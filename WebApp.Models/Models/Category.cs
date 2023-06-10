using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public IEnumerable<Product>? Products { get; set; }
}