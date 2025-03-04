using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> FindAll();
        Task<Task<IEnumerable<ProductDTO>>> FindById();
        Task<IEnumerable<ProductDTO>> Create(ProductDTO product);
        Task<IEnumerable<ProductDTO>> Update(ProductDTO product);
        Task<bool> Delete(long id);
    }
}
