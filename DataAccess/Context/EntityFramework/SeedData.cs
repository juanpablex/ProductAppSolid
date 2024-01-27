using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context.EntityFramework
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

            builder.Entity<StateType>().HasData(new List<StateType>
            {
                new StateType{ Id = 1,Name="Products"},
                new StateType{ Id = 2,Name="HHRR"},
                new StateType{ Id = 3,Name="Buildings"},
                new StateType{ Id = 4,Name="All"}
            });
            builder.Entity<State>().HasData(new List<State>
            {
                new State{ Id = 1,Name="Out of Stock",TypeId=1},
                new State{ Id = 2,Name="Getting out of stock",TypeId=1},
                new State{ Id = 3,Name="Active",TypeId=2},
                new State{ Id = 4,Name="Inactive",TypeId=2},
                new State{ Id = 5,Name="Opened",TypeId=3},
                new State{ Id = 6, Name="Closed",TypeId=3},
                new State{ Id = 7, Name="In-Stock",TypeId=4}
            });

        }
    }
}
