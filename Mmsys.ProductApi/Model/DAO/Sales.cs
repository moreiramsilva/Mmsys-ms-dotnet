using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmsys.ProductManagementApi.Model.Base;

namespace Mmsys.ProductManagementApi.Model.DAO
{
    [Table("sales")]
    public class Sales : BaseEntity
    {

        [Column("company_id")]
        [Required]
        public long CompanyId { get; set; }

        [Column("order_id")]
        [Required]
        public long OrderId { get; set; }

        [Column("product_id")]
        [Required]
        public long PersonId { get; set; }

    }
}
