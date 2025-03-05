using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonDTO>> FindAll();
        Task<PersonDTO> FindById(long Id);
        Task<PersonDTO> Create(PersonDTO person);
        Task<PersonDTO> Update(PersonDTO person);
        Task<bool> Delete(long Id);
    }
}
