namespace queue.Entities;

public class Order
{
    public int Id { get; set; }
    public List<OrderProduct> OrderProducts { get; set; } = new();
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Modified { get; set; }
}