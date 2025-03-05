using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mmsys.ProductManagementApi.DTO;
using Mmsys.ProductManagementApi.Model.DAO;
using Mmsys.ProductManagementApi.Repository.Interface;

namespace Mmsys.ProductManagementApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyRepository _repository;

        public CompanyController(ICompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> FindById(long Id)
        {
            var company = await _repository.FindById(Id);
            if (company == null) { return NotFound(); }
            return Ok(company);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerator<CompanyDTO>>> FindAll()
        {
            var companies = await _repository.FindAll();
            return Ok(companies);
        }
    }
}
