using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public static class SeedData
    {
       public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new List<Category>
            {
                new Category{ Id=1,Name="Electronics",Description="Includes electronic devices such as smartphones, laptops, cameras, and audio equipment"},
                new Category{ Id=2,Name="Grocery",Description="Comprises food and beverage items, pantry staples, fresh produce, and household consumables"},
                new Category{ Id=3,Name="Apparel",Description="Encompasses clothing items like shirts, pants, dresses, and outerwear for men, women, and children"},
                new Category{ Id=4,Name="Home Appliances",Description="Encompasses large and small household appliances, such as refrigerators, washing machines, microwaves, and vacuum cleaners"},
                new Category{ Id=5,Name="Toys and Games",Description="Involves toys for children, board games, puzzles, and other recreational items for entertainment"}
            });

            builder.Entity<ProductType>().HasData(new List<ProductType>
            {
                new ProductType{ Id=1,Name="Computing Devices",CategoryId=1},
                new ProductType{ Id=2,Name="Board Games",CategoryId=5},
                new ProductType{ Id=3,Name="Athletic Apparel",CategoryId=3},
                new ProductType{ Id=4,Name="Eggs",CategoryId=2},
                new ProductType{ Id=5,Name="Kitchen Appliances",CategoryId=4}
            });
            
        }
    }
}
