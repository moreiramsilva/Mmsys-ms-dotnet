using AutoMapper;
using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public OrderRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Task<OrderDTO> IOrderRepository.Create(OrderDTO order)
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

        Task<OrderDTO> IOrderRepository.FindById(long Id)
        {
            throw new NotImplementedException();
        }

        Task<OrderDTO> IOrderRepository.Update(OrderDTO order)
        {
            throw new NotImplementedException();
        }
    }
}
