
using System.Collections.Generic;
using ALILA_POS.Data;
using ALILA_POS.Domain;

namespace ALILA_POS.Services
{
    public class InventoryService
    {
        private readonly ProductRepository _productRepository;

        public InventoryService()
        {
            _productRepository = new ProductRepository();
        }
        public class CategoryService
        {
            private CategoryRepository _categoryRepository;

            public CategoryService()
            {
                _categoryRepository = new CategoryRepository();
            }

            public Dictionary<int, string> GetAllCategories()
            {
                return _categoryRepository.GetAll();
            }
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Dictionary<string, int> GetInventoryMetrics()
        {
            return _productRepository.GetInventoryMetrics();
        }

        // ADD PRODUCT
        public int AddProduct(Product product)
        {
            return _productRepository.Insert(product);
        }

        // UPDATE PRODUCT
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.Delete(productId);
        }

    }
}
