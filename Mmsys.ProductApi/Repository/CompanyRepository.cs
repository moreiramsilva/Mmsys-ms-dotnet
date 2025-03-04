using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        Task<IEnumerable<CompanyDTO>> ICompanyRepository.Create(CompanyDTO companyDTO)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICompanyRepository.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<CompanyDTO>> ICompanyRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Task<Task<IEnumerable<CompanyDTO>>> ICompanyRepository.FindById()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<CompanyDTO>> ICompanyRepository.Update(CompanyDTO companyDTO)
        {
            throw new NotImplementedException();
        }
    }
}
