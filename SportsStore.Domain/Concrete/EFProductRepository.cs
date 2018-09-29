using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

using System;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return this.context.Products; }
        }

        public Product DeleteProduct(Int32 productId)
        {
            Product entity = this.context.Products.Find(productId);
            if (entity != null)
            {
                this.context.Products.Remove(entity);
                this.context.SaveChanges();
            }
            return entity;
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
