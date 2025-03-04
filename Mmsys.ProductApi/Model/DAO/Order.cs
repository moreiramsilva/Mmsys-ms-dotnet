using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmsys.ProductManagementApi.Model.Base;

namespace Mmsys.ProductManagementApi.Model.DAO
{
    [Table("order")]
    public class Order : BaseEntity
    {
        [Column("order_date_time")]
        [Required]
        public DateTime OrderDateTime { get; set; }

        [Column("company_id")]
        [Required]
        public long CompanyId { get; set; }

        [Column("payment_type")]
        [Required]
        [StringLength(1)]
        public char PaymentType { get; set; }

        [Column("person_id")]
        public long PersonId { get; set; }

    }
}
