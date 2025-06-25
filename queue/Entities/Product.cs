using queue.Enums;

namespace queue.Entities;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public ProductTypeEnum Type { get; set; }
}