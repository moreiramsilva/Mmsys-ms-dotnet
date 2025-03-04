using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmsys.ProductManagementApi.Model.Base;

namespace Mmsys.ProductManagementApi.Model.DAO
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("description")]
        [StringLength(250)]
        public string? Description { get; set; }

        [Column("name")]
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }

        [Column("price")]
        [Required]
        [Range(0, 999999)]
        public decimal Price { get; set; }

        [Column("type")]
        [Required]
        [StringLength(1)]
        public string? Type { get; set; }

        [Column("quantity")]
        [Required]
        [Range(0, 999999)]
        public int Quantity { get; set; }

        [Column("companyId")]
        public long CompanyId { get; set; }

        [Column("image_url")]
        [StringLength(250)]
        public string? Image { get; set; }
    }
}
