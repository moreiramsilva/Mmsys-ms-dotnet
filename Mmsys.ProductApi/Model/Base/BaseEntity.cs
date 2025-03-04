using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mmsys.ProductManagementApi.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }

    }
}
