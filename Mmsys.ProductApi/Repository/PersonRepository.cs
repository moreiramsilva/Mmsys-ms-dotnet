using AutoMapper;
using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public PersonRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Task<PersonDTO> IPersonRepository.Create(PersonDTO person)
        {
            throw new NotImplementedException();
        }

        Task<bool> IPersonRepository.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<PersonDTO>> IPersonRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Task<PersonDTO> IPersonRepository.FindById(long Id)
        {
            throw new NotImplementedException();
        }

        Task<PersonDTO> IPersonRepository.Update(PersonDTO person)
        {
            throw new NotImplementedException();
        }
    }
}
