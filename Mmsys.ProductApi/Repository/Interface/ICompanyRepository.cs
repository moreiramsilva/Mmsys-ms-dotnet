using Mmsys.ProductManagementApi.DTO;

namespace Mmsys.ProductManagementApi.Repository.Interface
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyDTO>> FindAll();
        Task<CompanyDTO> FindById(long Id);
        Task<CompanyDTO> Create(CompanyDTO company);
        Task<CompanyDTO> Update(CompanyDTO company);
        Task<bool> Delete(long Id);
    }
}
