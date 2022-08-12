using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {

        #region Properties
        public DbSet<Product> Products { set; get; }
        #endregion

        #region CTOR
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        #endregion
    }
}
