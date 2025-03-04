namespace Mmsys.ProductManagementApi.DTO
{
    //CLASSE PARA ABSTRAIR O OBJETO PRODUCT
    public class SalesDTO
    {
        public long Id { get; set; }
        public CompanyDTO? Company { get; set; }
        public OrderDTO? Order { get; set; }
        public PersonDTO? Person { get; set; }
    }
}
