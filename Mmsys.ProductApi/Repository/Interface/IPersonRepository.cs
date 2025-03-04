using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonDTO>> FindAll();
        Task<Task<IEnumerable<PersonDTO>>> FindById();
        Task<IEnumerable<PersonDTO>> Create(PersonDTO person);
        Task<IEnumerable<PersonDTO>> Update(PersonDTO person);
        Task<bool> Delete(long id);
    }
}
