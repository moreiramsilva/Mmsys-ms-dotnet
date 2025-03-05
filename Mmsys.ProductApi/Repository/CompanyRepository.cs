using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Model.DAO;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CompanyRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        async Task<CompanyDTO> ICompanyRepository.Create(CompanyDTO companyDTO)
        {
            Company company = _mapper.Map<Company>(companyDTO);
            _context.Add(company);
            await _context.SaveChangesAsync();
            return _mapper.Map<CompanyDTO>(company);
        }
        async Task<bool> ICompanyRepository.Delete(long Id)
        {
            try
            {
                Company company = await _context.Companys.Where(p => p.Id == Id).FirstOrDefaultAsync();
                if (company == null)
                {
                    return false;
                }
                _context.Remove(company);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        async Task<IEnumerable<CompanyDTO>> ICompanyRepository.FindAll()
        {
            List<Company> company = await _context.Companys.ToListAsync();
            return _mapper.Map<List<CompanyDTO>>(company);
        }
        async Task<CompanyDTO> ICompanyRepository.FindById(long Id)
        {
            Company company = await _context.Companys.Where(p => p.Id == Id).FirstOrDefaultAsync();
            return _mapper.Map<CompanyDTO>(company);
        }
        async Task<CompanyDTO> ICompanyRepository.Update(CompanyDTO companyDTO)
        {
            Company company = _mapper.Map<Company>(companyDTO);
            _context.Companys.Update(company);
            await _context.SaveChangesAsync();
            return _mapper.Map<CompanyDTO>(company);
        }
    }
}
