using RJ.Tokoku.DataLayer.InventoryManagement;
using RJ.Tokoku.DataLayer.Master;
using RJ.Tokoku.DataLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.DataLayer
{
    public class UnitOfWork : IDisposable
    {
        private AppContext context = new AppContext();
        private GenericRepository<ProductGroup> productGroupRepo;
        private GenericRepository<Product> productRepo;
        private GenericRepository<Warehouse> warehouseRepo;

        #region Dimension Management
        private GenericRepository<ColorDim> colorDimRepo;
        public GenericRepository<ColorDim> ColorDimRepo { get => colorDimRepo ?? new GenericRepository<ColorDim>(context); }
        #endregion

        private bool disposed = false;
        public GenericRepository<Product> ProductRepo { get => productRepo ?? new GenericRepository<Product>(context); }
        public GenericRepository<ProductGroup> ProductGroupRepo { get => productGroupRepo ?? new GenericRepository<ProductGroup>(context); }

        #region Inventory Management
        public GenericRepository<Warehouse> WarehouseRepo { get => warehouseRepo ?? new GenericRepository<Warehouse>(context); }
        #endregion


        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
