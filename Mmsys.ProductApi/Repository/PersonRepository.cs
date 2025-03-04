using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class PersonRepository : IPersonRepository
    {
        Task<IEnumerable<PersonDTO>> IPersonRepository.Create(PersonDTO person)
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

        Task<Task<IEnumerable<PersonDTO>>> IPersonRepository.FindById()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<PersonDTO>> IPersonRepository.Update(PersonDTO person)
        {
            throw new NotImplementedException();
        }
    }
}
