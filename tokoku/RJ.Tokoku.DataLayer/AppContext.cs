using RJ.Tokoku.DataLayer.InventoryManagement;
using RJ.Tokoku.DataLayer.Master;
using RJ.Tokoku.DataLayer.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=appconn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductEntityConfiguration());
            modelBuilder.Configurations.Add(new ProductGroupEntityConfiguration());
            modelBuilder.Configurations.Add(new ColorDimEntityConfiguration());
            modelBuilder.Configurations.Add(new WarehouseEntityConfiguration());
        }

        #region DBSET

        #region Product
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductGroup> ProductGroup { get; set; }
        #endregion

        #region Master
        public DbSet<ColorDim> ColorDim { get; set; }
        #endregion

        #region Inventory
        public DbSet<Warehouse> Warehouse { get; set; }
        #endregion

        #endregion

    }
}
