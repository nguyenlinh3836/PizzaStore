using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using PizzaStore.Models;


namespace PizzaStore.Models
{
    public class ProductDatabaseInitializer: DropCreateDatabaseAlways<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            GetSizes().ForEach(c => context.Sizes.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
    }
}
