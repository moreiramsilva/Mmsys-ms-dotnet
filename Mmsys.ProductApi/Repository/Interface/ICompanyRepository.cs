using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyDTO>> FindAll();
        Task<Task<IEnumerable<CompanyDTO>>> FindById();
        Task<IEnumerable<CompanyDTO>> Create(CompanyDTO companyDTO);
        Task<IEnumerable<CompanyDTO>> Update(CompanyDTO companyDTO);
        Task<bool> Delete(long id);
    }
}
