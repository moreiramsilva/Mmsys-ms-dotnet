using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmsys.ProductManagementApi.Model.Base;

namespace Mmsys.ProductManagementApi.Model.DAO
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("name")]
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }

        [Column("cpf_cnpj")]
        [StringLength(14)]
        public string? CpfCnpj { get; set; }

        [Column("person_type")]
        [StringLength(1)]
        public char PersonType { get; set; }

        [Column("registration_type")]
        [Required]
        [StringLength(1)]
        public char RegistrationType { get; set; }

        [Column("phone")]
        [StringLength(25)]
        public string? Phone { get; set; }

        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }

        [Column("address")]
        [StringLength(250)]
        public string? Address { get; set; }

        [Column("description")]
        [StringLength(250)]
        public long Description { get; set; }

        [Column("company_id")]
        [Required]
        public long CompanyId { get; set; }
    }
}
