using DevOn.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.DB.Seed
{
    public static class DbInitializer
    {
        public static void Initialize(DevOnDbContext context)
        {
            context.Database.EnsureCreated();
            if(context.Categories.Any())
            {
                return;
            }
            var categories = new Category[]
            {
                new Category()
                {
                    Created=DateTime.Now,
                    Name="Food"
                  

                },
                  new Category()
                {
                    Created=DateTime.Now,
                    Name="Electronics"
                 

                },

                  new Category()
                {
                    Created=DateTime.Now,
                    Name="Fasion"
                  

                },
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();
            var products = new Product[]
            {
                new Product()
                {
                    Name="T-Shirt",                    
                    Description="Colored",
                    Created=DateTime.Now,
                    Quantity=3,
                    CategoryID=3
                },
                 new Product()
                {
                    Name="Mobile",                   
                    Description="Keypad",
                    Created=DateTime.Now,
                    Quantity=6,
                    CategoryID=2
                },
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
