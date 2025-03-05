using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface ISalesRepository
    {
        Task<IEnumerable<SalesDTO>> FindAll();
        Task<SalesDTO> FindById(long Id);
        Task<SalesDTO> Create(SalesDTO sales);
        Task<SalesDTO> Update(SalesDTO sales);
        Task<bool> Delete(long Id);
    }
}
