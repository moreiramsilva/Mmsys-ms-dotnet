using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmsys.ProductManagementApi.Model.Base;

namespace Mmsys.ProductManagementApi.Model.DAO
{
    [Table("Company")]
    public class Company : BaseEntity
    {
        [Column("email")]
        [StringLength(250)]
        [Required]
        public string? Email { get; set; }

        [Column("name")]
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }

        [Column("description")]
        [Required]
        [StringLength(250)]
        public decimal Description { get; set; }

        [Column("company_image_url")]
        [StringLength(250)]
        public string? CompanyImage { get; set; }
    }
}
