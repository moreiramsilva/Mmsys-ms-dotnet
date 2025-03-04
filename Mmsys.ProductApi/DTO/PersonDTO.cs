namespace Mmsys.ProductManagementApi.DTO
{
    //CLASSE PARA ABSTRAIR O OBJETO PERSON
    public class PersonDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? CpfCnpj { get; set; }
        public char PersonType { get; set; }
        public char RegistrationType { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public long Description { get; set; }
        public CompanyDTO? Company { get; set; }
    }
}
