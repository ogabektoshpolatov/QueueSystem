using Microsoft.AspNetCore.Components;
using queue.Entities;

namespace queue.Pages;
using queue.Services.Interfaces;

public partial class Products
{
    [Inject]
    public IProductService ProductService { get; set; } 
    public List<Product> AllProducts { get; set; } = new();
    

    protected override async Task OnInitializedAsync()
    {
        AllProducts = (await ProductService.GetPagedAsync(1, 10)).ToList();
    }
}