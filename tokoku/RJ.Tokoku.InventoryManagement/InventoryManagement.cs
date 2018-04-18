using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJ.Tokoku.DataLayer;
using RJ.Tokoku.DataLayer.InventoryManagement;

namespace RJ.Tokoku.Inventory
{
    public class InventoryManagement
    {
        private UnitOfWork _uow = new UnitOfWork();

        public Warehouse CreateWarehouse(Warehouse warehouse)
        {
            _uow.WarehouseRepo.Insert(warehouse);
            _uow.Save();
            return warehouse;
        }

        public Warehouse EditWarehouse(Warehouse warehouse)
        {
            _uow.WarehouseRepo.Update(warehouse);
            _uow.Save();
            return warehouse;
        }

        public bool DeleteWarehouse(Warehouse warehouse)
        {
            try
            {
                _uow.WarehouseRepo.Delete(warehouse);
                _uow.Save();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Warehouse> GetAllWarehouse() => _uow.WarehouseRepo.Get();
        public Warehouse GetWarehouseById(string code) => _uow.WarehouseRepo.GetById(code);
    }
}
