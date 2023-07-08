using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace BeansBurgers_v2.Data
{

    public static class ModelBuilderExtensions
    {


        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {

            //Ingredient[] dataIngredients = {
            modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient
            {
                Id = 1,
                Name = "Brioche",
                ExtraCost = 3.50f,
                Category = 0
            },
            new Ingredient
            {
                Id = 2,
                Name = "Ciabatta",
                ExtraCost = 3.50f,
                Category = 0
            },
            new Ingredient
            {
                Id = 3,
                Name = "Whole Wheat Brioche",
                ExtraCost = 3.75f,
                Category = 0
            },
            new Ingredient
            {
                Id = 4,
                Name = "Sesame Seed Brioche",
                ExtraCost = 3.75f,
                Category = 0
            },
            new Ingredient
            {
                Id = 5,
                Name = "Poppy Seed Brioche",
                ExtraCost = 3.75f,
                Category = 0
            },
            new Ingredient
            {
                Id = 6,
                Name = "Angus Beef",
                ExtraCost = 7.05f,
                Category = 1
            },
            new Ingredient
            {
                Id = 7,
                Name = "Fried Chicken",
                ExtraCost = 6.50f,
                Category = 1
            },
            new Ingredient
            {
                Id = 8,
                Name = "Fish Cake",
                ExtraCost = 6.00f,
                Category = 1
            },
            new Ingredient
            {
                Id = 9,
                Name = "Bison",
                ExtraCost = 8.00f,
                Category = 1
            },
            new Ingredient
            {
                Id = 10,
                Name = "Beyond Meat",
                ExtraCost = 7.00f,
                Category = 1
            },
            new Ingredient
            {
                Id = 11,
                Name = "Portobello",
                ExtraCost = 5.50f,
                Category = 1
            },
            new Ingredient
            {
                Id = 12,
                Name = "Lettuce",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 13,
                Name = "Tomatoes",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 14,
                Name = "Pickles",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 15,
                Name = "Red Onions",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 16,
                Name = "Caramelized Onions",
                ExtraCost = 3.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 17,
                Name = "Mushrooms",
                ExtraCost = 3.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 18,
                Name = "Banana Peppers",
                ExtraCost = 3.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 19,
                Name = "Cheddar Cheese",
                ExtraCost = 4.00f,
                Category = 2
            },
            new Ingredient
            {
                Id = 20,
                Name = "Bacon",
                ExtraCost = 7.00f,
                Category = 2
            },
            new Ingredient
            {
                Id = 21,
                Name = "Jalapeno Monterey Jack",
                ExtraCost = 4.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 22,
                Name = "Swiss Cheese",
                ExtraCost = 4.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 23,
                Name = "Goat Cheese",
                ExtraCost = 4.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 24,
                Name = "Ketchup",
                ExtraCost = 3.00f,
                Category = 3
            },
            new Ingredient
            {
                Id = 25,
                Name = "Mustard",
                ExtraCost = 3.00f,
                Category = 3
            },
            new Ingredient
            {
                Id = 26,
                Name = "Relish",
                ExtraCost = 3.00f,
                Category = 3
            },
            new Ingredient
            {
                Id = 27,
                Name = "Mayonnaise",
                ExtraCost = 3.25f,
                Category = 3
            },
            new Ingredient
            {
                Id = 28,
                Name = "Spicy Mayonnaise",
                ExtraCost = 3.50f,
                Category = 3
            },
            new Ingredient
            {
                Id = 29,
                Name = "Tartar Sauce",
                ExtraCost = 3.25f,
                Category = 3
            },
            new Ingredient
            {
                Id = 30,
                Name = "Barbecue Sauce",
                ExtraCost = 3.25f,
                Category = 3
            },
            new Ingredient
            {
                Id = 31,
                Name = "Pico de Gallo",
                ExtraCost = 3.50f,
                Category = 3
            },
            new Ingredient
            {
                Id = 32,
                Name = "Guacamole",
                ExtraCost = 3.75f,
                Category = 3
            }
            );

            //};
            // modelBuilder.Entity<Ingredient>().HasData(dataIngredients);


            modelBuilder.Entity<MenuItem>().HasData(

                new MenuItem
                {
                    Id = 1,
                    Name = "Fries",
                    Price = 5.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Fries.png"

                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Poutine",
                    Price = 7.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Poutine.png"
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Chicken Nuggets",
                    Price = 6.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Chicken Nuggets.png"
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Onion Rings",
                    Price = 6.00f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Onion Rings.png"
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Fried Pickles",
                    Price = 5.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Fried Pickles.png"
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Cheese Sticks",
                    Price = 7.00f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Cheese Sticks.png"
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Pepsi",
                    Price = 3.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Pepsi.png"
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "7-Up",
                    Price = 3.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/7up.png"
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Iced Tea",
                    Price = 3.50f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Iced Tea.png"
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Dom Perignon Brut Champagne",
                    Price = 214.97f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Dom Perignon Brut Champagne.png"
                },
                new MenuItem
                {
                    Id = 11,
                    Name = "Celebrity Appearance",
                    Price = 999.99f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Arnold.jpg"
                },
                new MenuItem
                {
                    Id = 12,
                    Name = "24 Karat Gold Leaf",
                    Price = 15.00f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/24 Karat Gold Leaf.png"
                },
                new MenuItem
                {
                    Id = 13,
                    Name = "Glenfarclas Single Malt 25",
                    Price = 199.99f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Glenfarclas Single Malt 25.png"
                },
                new MenuItem
                {
                    Id = 14,
                    Name = "Diner avec Jay-Z",
                    Price = 500000.00f,
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Diner avec Jay-Z.png"
                },

                new MenuItem
                {
                    Id = 15,
                    Name = "La Basique",
                    Price = 29.25f,
                    Description = "Brioche Bread, Angus Beef, Lettuce, Tomatoes, Pickles, Ketchup, Mustard Relish",
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Cheese Sticks.png"

                },
                new MenuItem
                {
                    Id = 16,
                    Name = "Le Fumé",
                    Price = 31.99f,
                    Description = "Sesame Seed Brioche, Angus Beef, Caramelized Onions, Mushrooms, Cheddar Cheese, Bacon, Barbecue Sauce",
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Le Fumé.png"
                },
                new MenuItem
                {
                    Id = 17,
                    Name = "La Volaille",
                    Price = 24.50f,
                    Description = "Poppy Seed Brioche, Fried Chicken, Lettuce, Tomatoes, Goat Cheese, Spicy Mayonnaise",
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/La Volaille.png"
                },
                 new MenuItem
                 {
                     Id = 18,
                     Name = "La Piscicole",
                     Price = 22.50f,
                     Description = "Ciabatta, Fish Cake, Lettuce, Tomatoes, Pickles, Tartar Sauce",
                     ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/La Piscicole.png"
                 },
                 new MenuItem
                 {
                     Id = 19,
                     Name = "Le Champignon",
                     Price = 31.25f,
                     Description = "Poppy Seed Brioche, Portobello, Lettuce, Tomatoes, Pickles, Red Onions, Ketchup, Mustard, Relish",
                     ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Le Champignon.png"
                 },
                new MenuItem
                {
                    Id = 20,
                    Name = "La Pastourelle",
                    Price = 35.75f,
                    Description = "Sesame Seed Brioche, Bison Patty, Lettuce, Tomatoes, Pickles, Caramelized Onions, Swiss Cheese, Mustard, Mayonnaise",
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/La Pastourelle.png"
                },
                new MenuItem
                {
                    Id = 21,
                    Name = "Le Mex",
                    Price = 31.75f,
                    Description = "Brioche, Angus Beef, Lettuce, Tomatoes, Pickles, Jalapeno Monterey Jack, Pico de Gallo, Guacamole",
                    ImageName = "https://beansburgersblobs.blob.core.windows.net/beansburgers/Le Mex.png"
                }
            );
            return modelBuilder;
        }
    }
}