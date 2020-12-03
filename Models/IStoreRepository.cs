using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Size>Sizes { get; }
    }
}
