using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderDTO>> FindAll();
        Task<Task<IEnumerable<OrderDTO>>> FindById();
        Task<IEnumerable<OrderDTO>> Create(OrderDTO order);
        Task<IEnumerable<OrderDTO>> Update(OrderDTO order);
        Task<bool> Delete(long id);
    }
}
