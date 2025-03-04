using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface ISalesRepository
    {
        Task<IEnumerable<SalesDTO>> FindAll();
        Task<Task<IEnumerable<SalesDTO>>> FindById();
        Task<IEnumerable<SalesDTO>> Create(SalesDTO sales);
        Task<IEnumerable<SalesDTO>> Update(SalesDTO sales);
        Task<bool> Delete(long id);
    }
}
