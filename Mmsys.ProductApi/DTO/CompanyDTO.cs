
namespace Mmsys.ProductManagementApi.DTO
{
    //CLASSE PARA ABSTRAIR O OBJETO COMPANY
    public class CompanyDTO
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public decimal Description { get; set; }
        public string? CompanyImage { get; set; }
    }
}
