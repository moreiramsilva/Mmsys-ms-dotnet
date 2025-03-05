using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderDTO>> FindAll();
        Task<OrderDTO> FindById(long Id);
        Task<OrderDTO> Create(OrderDTO order);
        Task<OrderDTO> Update(OrderDTO order);
        Task<bool> Delete(long Id);
    }
}
