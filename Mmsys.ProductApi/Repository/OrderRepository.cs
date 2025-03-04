using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        Task<IEnumerable<OrderDTO>> IOrderRepository.Create(OrderDTO order)
        {
            throw new NotImplementedException();
        }

        Task<bool> IOrderRepository.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<OrderDTO>> IOrderRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Task<Task<IEnumerable<OrderDTO>>> IOrderRepository.FindById()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<OrderDTO>> IOrderRepository.Update(OrderDTO order)
        {
            throw new NotImplementedException();
        }
    }
}
