using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RJ.Tokoku.DataLayer;
using RJ.Tokoku.DataLayer.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Tokoku.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            UnitOfWork uow = new UnitOfWork();
            var product = new Product()
            {
                ProductCode = "PR",
                Name = "A",
                ProductGroupRef = uow.ProductGroupRepo.GetById("XXXXX")
            };
            var prd = uow.ProductRepo.Insert(product);
            uow.Save();
            System.Console.WriteLine($"Product : {prd.ProductCode}");
            System.Console.Read();
            */

            Database.SetInitializer(new DropCreateDatabaseAlways<AppContext>());
            using (var app = new AppContext())
            {
                var productGroup = new ProductGroup()
                {
                    ProductGroupCode = "SBEGOFQ777124",
                    Description = "SBEGO FQ777 124"
                };
                app.ProductGroup.Add(productGroup);
                app.SaveChanges();
            }
            /*
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            userManager.Create(new IdentityUser("rjx@rjx.com"), "1234567890");
            */
        }
    }
}
