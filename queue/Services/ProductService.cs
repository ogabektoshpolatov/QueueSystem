using queue.Data;
using queue.Entities;
using queue.Services.Interfaces;

namespace queue.Services;

public class ProductService(AppDbContext dbContext):GenericService<Product>(dbContext), IProductService
{

}