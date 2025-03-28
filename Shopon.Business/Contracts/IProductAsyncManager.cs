using Shopon.Common.Models;

namespace Shopon.Business.Contracts
{
    /// <summary>
    /// The IProductAsyncManager
    /// </summary>
    public interface IProductAsyncManager
    {
        /// <summary>
        /// Method to add new product async
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Newly added product.</returns>
        public Task<Product> AddProductAsync(Product product);

        /// <summary>
        /// Method to get product by id async
        /// </summary>
        /// <returns>List of products</returns>
        public Task<IEnumerable<Product>> GetAllProductsAsync();

        /// <summary>
        /// Method to get the product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product by id if found, else returns null</returns>
        public Task<Product?> GetProductByIdAsync(int id);

        /// <summary>
        /// Method to update product async
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Updated product if found, else return null</returns>
        public Task<Product?> UpdateProductAsync(Product product);

        /// <summary>
        /// Method to deleted product async
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Deleted product if found, else returns null</returns>
        public Task<Product?> DeleteProductAsync(int id);

        /// <summary>
        /// Method to search products async
        /// </summary>
        /// <param name="search"></param>
        /// <returns>List of products based on search if found, else returns null</returns>
        public Task<IEnumerable<Product>> SearchProductsAsync(string search);
    }
}

