using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        Task<IEnumerable<ProductDTO>> IProductRepository.Create(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        Task<bool> IProductRepository.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ProductDTO>> IProductRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Task<Task<IEnumerable<ProductDTO>>> IProductRepository.FindById()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ProductDTO>> IProductRepository.Update(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
