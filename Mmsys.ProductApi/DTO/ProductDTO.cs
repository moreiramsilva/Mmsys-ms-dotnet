namespace Mmsys.ProductManagementApi.DTO
{
    //CLASSE PARA ABSTRAIR O OBJETO PRODUCT
    public class ProductDTO
    {
        public long Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; } 
        public string? Type { get; set; }
        public int Quantity { get; set; }
        public CompanyDTO? CompanyId { get; set; }
        public string? Image { get; set; }
    }
}
