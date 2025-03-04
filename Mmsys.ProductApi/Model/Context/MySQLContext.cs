using Microsoft.EntityFrameworkCore;
using Mmsys.ProductManagementApi.Model.Context;
using Mmsys.ProductManagementApi.Model.DAO;

namespace Mmsys.ProductManagementApi.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> opt) : base(opt) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companys { get; set; }


    }
}
