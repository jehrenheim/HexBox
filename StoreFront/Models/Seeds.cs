using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StoreFront.Models
{
    public static class Seeds
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new StoreContext(serviceProvider.GetRequiredService<DbContextOptions<StoreContext>>())){
                if(context.Product.Any()){
                    return;
                }
                context.Product.AddRange(
                    new Product { Name = "Notebook", Category = "Stationary", ID = 0, Price = 12.99M },
                    new Product { Name = "Calendar", Category = "Organization", ID = 1, Price = 19.99M },
                    new Product { Name = "Thank You Cards", Category = "Stationary", ID = 2, Price = 7.99M },
                    new Product { Name = "Notepad", Category = "Organization", ID = 3, Price = 5.99M },
                    new Product { Name = "Poster", Category = "Art", ID = 4, Price = 24.99M },
                    new Product { Name = "Poster 2", Category = "Art", ID = 5, Price = 24.99M }
                );
                context.SaveChanges();
            }
        }
    }
}
