namespace Mmsys.ProductManagementApi.DTO
{
    //CLASSE PARA ABSTRAIR O OBJETO ORDER
    public class OrderDTO
    {
        public long Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public CompanyDTO? Company { get; set; }
        public char PaymentType { get; set; }
        public PersonDTO? Person { get; set; }
    }
}
