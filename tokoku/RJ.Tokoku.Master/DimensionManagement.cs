using RJ.Tokoku.DataLayer;
using RJ.Tokoku.DataLayer.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.Master
{
    public class DimensionManagement
    {
        UnitOfWork uow = new UnitOfWork();

        public ColorDim CreateColorDim(ColorDim colorDim)
        {
            uow.ColorDimRepo.Insert(colorDim);
            uow.Save();
            return colorDim;
        }

        public ColorDim EditColorDim(ColorDim colorDim)
        {
            uow.ColorDimRepo.Update(colorDim);
            uow.Save();
            return colorDim;
        }

        public bool DeleteColorDim(ColorDim colorDim)
        {
            try
            {
                uow.ColorDimRepo.Delete(colorDim);
                uow.Save();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public ColorDim GetColorDimById(string colorDimCode) => uow.ColorDimRepo.GetById(colorDimCode);
        public IEnumerable<ColorDim> GetAllColorDim() => uow.ColorDimRepo.Get();
    }
}
