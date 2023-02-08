using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace BeansBurgers_v2.Data {

    public static class ModelBuilderExtensions {

        public static ModelBuilder Seed(this ModelBuilder modelBuilder) {

            modelBuilder.Entity<MenuItem>().HasData (

                new MenuItem {
                    Id = 1,
                    Name = "Brioche",
                    Price = 3.50f,
                    Description = null
                },
                                new MenuItem {
                    Id = 2,
                    Name = "Ciabatta",
                    Price = 3.50f,
                    Description = null
                },
                                new MenuItem {
                    Id = 3,
                    Name = "Whole Wheet Brioche",
                    Price = 3.75f,
                    Description = null
                },
                                new MenuItem {
                    Id = 4,
                    Name = "Sesame Seed Brioche",
                    Price = 3.70f,
                    Description = null
                },
                                new MenuItem {
                    Id = 5,
                    Name = "Poppy Seed Brioche",
                    Price = 3.75f,
                    Description = null
                },
                                new MenuItem {
                    Id = 6,
                    Name = "Angus Beef",
                    Price = 7.50f,
                    Description = null
                },
                                new MenuItem {
                    Id = 7,
                    Name = "Fried Chicken",
                    Price = 6.50f,
                    Description = null
                },
                                new MenuItem {
                    Id = 8,
                    Name = "Fish Cake",
                    Price = 6.00f,
                    Description = null
                },
                                new MenuItem {
                    Id = 9,
                    Name = "Bison",
                    Price = 8.00f,
                    Description = null
                },
                                new MenuItem {
                    Id = 1,
                    Name = "Beyond Meat",
                    Price = 7.00f,
                    Description = null
                }
            );
            return modelBuilder;
        }
    }
}