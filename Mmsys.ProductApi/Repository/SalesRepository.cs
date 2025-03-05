using AutoMapper;
using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class SalesRepository : ISalesRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public SalesRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Task<SalesDTO> ISalesRepository.Create(SalesDTO sales)
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

        Task<SalesDTO> ISalesRepository.FindById(long Id)
        {
            throw new NotImplementedException();
        }

        Task<SalesDTO> ISalesRepository.Update(SalesDTO sales)
        {
            throw new NotImplementedException();
        }
    }
}
