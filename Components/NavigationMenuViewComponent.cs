using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace PizzaStore.Components
{  
        public class NavigationMenuViewComponent : ViewComponent
        {
            private IStoreRepository repository;

            public NavigationMenuViewComponent(IStoreRepository repo)
            {
                repository = repo;
            }
            public IViewComponentResult Invoke()
            {
                return View(repository.Products
                    .Select(x => x.Category)
                    .Distinct()
                    .OrderBy(x => x));
            }
        
    }
}
