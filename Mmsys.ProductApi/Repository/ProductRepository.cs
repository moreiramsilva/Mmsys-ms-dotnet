using AutoMapper;
using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Task<ProductDTO> IProductRepository.Create(ProductDTO productDTO)
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

        Task<ProductDTO> IProductRepository.FindById(long Id)
        {
            throw new NotImplementedException();
        }

        Task<ProductDTO> IProductRepository.Update(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
