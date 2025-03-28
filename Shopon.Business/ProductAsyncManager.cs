using Shopon.Business.Contracts;
using Shopon.Common.Models;
using Shopon.Data.Contracts;

namespace Shopon.Business
{
    /// <summary>
    /// The IProductAsyncManager
    /// </summary>
    public class ProductAsyncManager : IProductAsyncManager
    {
        private readonly IProductAsyncRepository productRepo;

        public ProductAsyncManager(IProductAsyncRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        public Task<Product> AddProductAsync(Product product) => this.productRepo.AddProductAsync(product);
        

        public Task<Product?> DeleteProductAsync(int id) => this.productRepo.DeleteProductAsync(id);
        

        public Task<IEnumerable<Product>> GetAllProductsAsync() => this.productRepo.GetAllProductsAsync();
        
        public Task<Product?> GetProductByIdAsync(int id) => productRepo.GetProductByIdAsync(id);

        public Task<IEnumerable<Product>> SearchProductsAsync(string search) => productRepo.SearchProductsAsync(search);
        

        public Task<Product?> UpdateProductAsync(Product product) => productRepo.UpdateProductAsync(product);
    }
}
