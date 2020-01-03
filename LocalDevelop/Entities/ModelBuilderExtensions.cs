using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDevelop.Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Dell Notebook XPS 13",
                        Detail = "ABCD",
                        Amount = 10,
                        Price = 55000
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Lenovo X230",
                        Detail = "ABCD",
                        Amount = 5,
                        Price = 32000
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Microsoft Surface Pro 7",
                        Detail = "ABCD",
                        Amount = 3,
                        Price = 60000
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Apple X Pro 2020",
                        Detail = "ABCD",
                        Amount = 10,
                        Price = 45000
                    },
                    new Product
                    {
                        Id = 10,
                        Name = "Apple Mac Pro",
                        Detail = "ABCD",
                        Amount = 1,
                        Price = 100000
                    },
                    new Product
                    {
                        Id = 11,
                        Name = "Apple Ipad 2018",
                        Detail = "ABCD",
                        Amount = 20,
                        Price = 15000
                    },
                    new Product
                    {
                        Id = 12,
                        Name = "Apple Ipad 2018",
                        Detail = "ABCD",
                        Amount = 20,
                        Price = 15000
                    },
                    new Product
                    {
                        Id = 13,
                        Name = "Apple Ipad 2018",
                        Detail = "ABCD",
                        Amount = 20,
                        Price = 15000
                    }
                );
        }
    }
}