using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class SalesRepository : ISalesRepository
    {
        Task<IEnumerable<SalesDTO>> ISalesRepository.Create(SalesDTO sales)
        {
            throw new NotImplementedException();
        }

        Task<bool> ISalesRepository.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<SalesDTO>> ISalesRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Task<Task<IEnumerable<SalesDTO>>> ISalesRepository.FindById()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<SalesDTO>> ISalesRepository.Update(SalesDTO sales)
        {
            throw new NotImplementedException();
        }
    }
}
