using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return this.context.Products; }
        }

        public void SaveProduct(Product prop)
        {
            if (prop.ProductID == 0)
            {
                this.context.Products.Add(prop);
            }
            else
            {
                Product entity = this.context.Products.Find(prop.ProductID);
                if (entity != null)
                {
                    entity.Name = prop.Name;
                    entity.Category = prop.Description;
                    entity.Price = prop.Price;
                }
            }

            this.context.SaveChanges();
        }
    }
}
