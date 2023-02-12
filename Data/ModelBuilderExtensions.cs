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
                PriceId = "price_1MaPG8BCj4yzLlBM6oasFbvw",
                Name = "Brioche",
                ExtraCost = 3.50f,
                Category = 0
            },
            new Ingredient
            {
                Id = 2,
                PriceId = "price_1MaPGzBCj4yzLlBM3KjO1Kpx",
                Name = "Ciabatta",
                ExtraCost = 3.50f,
                Category = 0
            },
            new Ingredient
            {
                Id = 3,
                PriceId = "price_1MaPIJBCj4yzLlBM4t7YOJia",
                Name = "Whole Wheat Brioche",
                ExtraCost = 3.75f,
                Category = 0
            },
            new Ingredient
            {
                Id = 4,
                PriceId = "price_1MaU5XBCj4yzLlBMcwJjmimD",
                Name = "Sesame Seed Brioche",
                ExtraCost = 3.75f,
                Category = 0
            },
            new Ingredient
            {
                Id = 5,
                PriceId = "price_1MaU4cBCj4yzLlBMQDfT35em",
                Name = "Poppy Seed Brioche",
                ExtraCost = 3.75f,
                Category = 0
            },
            new Ingredient
            {
                Id = 6,
                PriceId = "price_1MaPNTBCj4yzLlBMszenSdXm",
                Name = "Angus Beef",
                ExtraCost = 7.05f,
                Category = 1
            },
            new Ingredient
            {
                Id = 7,
                PriceId = "price_1MaPO5BCj4yzLlBMebcKoU5G",
                Name = "Fried Chicken",
                ExtraCost = 6.50f,
                Category = 1
            },
            new Ingredient
            {
                Id = 8,
                PriceId = "price_1MaPOyBCj4yzLlBMVwvLdnCk",
                Name = "Fish Cake",
                ExtraCost = 6.00f,
                Category = 1
            },
            new Ingredient
            {
                Id = 9,
                PriceId = "price_1MaPPWBCj4yzLlBMjq9gmgCF",
                Name = "Bison",
                ExtraCost = 8.00f,
                Category = 1
            },
            new Ingredient
            {
                Id = 10,
                PriceId = "price_1MaPQ8BCj4yzLlBMqjv0IOde",
                Name = "Beyond Meat",
                ExtraCost = 7.00f,
                Category = 1
            },
            new Ingredient
            {
                Id = 11,
                PriceId = "price_1MaPQZBCj4yzLlBMQryc3PAO",
                Name = "Portobello",
                ExtraCost = 5.50f,
                Category = 1
            },
            new Ingredient
            {
                Id = 12,
                PriceId = "price_1MaPQvBCj4yzLlBMIGPZJ18h",
                Name = "Lettuce",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 13,
                PriceId = "price_1MaPT6BCj4yzLlBMtZxovoxA",
                Name = "Tomatoes",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 14,
                PriceId = "price_1MaPTVBCj4yzLlBM9gieukCY",
                Name = "Pickles",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 15,
                PriceId = "price_1MaPTwBCj4yzLlBMUSUJ5e6b",
                Name = "Red Onions",
                ExtraCost = 3.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 16,
                PriceId = "price_1MaPUHBCj4yzLlBMadRPMN5j",
                Name = "Caramelized Onions",
                ExtraCost = 3.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 17,
                PriceId = "price_1MaPUbBCj4yzLlBMhGwIkB2G",
                Name = "Mushrooms",
                ExtraCost = 3.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 18,
                PriceId = "price_1MaU0PBCj4yzLlBMRsjQlDe7",
                Name = "Banana Peppers",
                ExtraCost = 3.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 19,
                PriceId = "price_1MaPUwBCj4yzLlBMH47I4iSy",
                Name = "Cheddar Cheese",
                ExtraCost = 4.00f,
                Category = 2
            },
            new Ingredient
            {
                Id = 20,
                PriceId = "price_1MaPVkBCj4yzLlBM02MDuAD1",
                Name = "Bacon",
                ExtraCost = 7.00f,
                Category = 2
            },
            new Ingredient
            {
                Id = 21,
                PriceId = "price_1MaPW6BCj4yzLlBMlPVM9Nif",
                Name = "Jalapeno Monterey Jack",
                ExtraCost = 4.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 22,
                PriceId = "price_1MaPWVBCj4yzLlBMb7aylAzK",
                Name = "Swiss Cheese",
                ExtraCost = 4.50f,
                Category = 2
            },
            new Ingredient
            {
                Id = 23,
                PriceId = "price_1MaPWrBCj4yzLlBM5dcYdjJK",
                Name = "Goat Cheese",
                ExtraCost = 4.25f,
                Category = 2
            },
            new Ingredient
            {
                Id = 24,
                PriceId = "price_1MaPX9BCj4yzLlBMxmKZ8wIf",
                Name = "Ketchup",
                ExtraCost = 3.00f,
                Category = 3
            },
            new Ingredient
            {
                Id = 25,
                PriceId = "price_1MaPXZBCj4yzLlBMPtVcmtUS",
                Name = "Mustard",
                ExtraCost = 3.00f,
                Category = 3
            },
            new Ingredient
            {
                Id = 26,
                PriceId = "price_1MaTy7BCj4yzLlBMMeRYOKUE",
                Name = "Relish",
                ExtraCost = 3.00f,
                Category = 3
            },
            new Ingredient
            {
                Id = 27,
                PriceId = "price_1MaPk2BCj4yzLlBMAyFjfQOb",
                Name = "Mayonnaise",
                ExtraCost = 3.25f,
                Category = 3
            },
            new Ingredient
            {
                Id = 28,
                PriceId = "price_1MaPmPBCj4yzLlBMlcYjC89X",
                Name = "Spicy Mayonnaise",
                ExtraCost = 3.50f,
                Category = 3
            },
            new Ingredient
            {
                Id = 29,
                PriceId = "price_1MaPmfBCj4yzLlBM1jttErHA",
                Name = "Tartar Sauce",
                ExtraCost = 3.25f,
                Category = 3
            },
            new Ingredient
            {
                Id = 30,
                PriceId = "price_1MaTvOBCj4yzLlBMOXvxjLzA",
                Name = "Barbecue Sauce",
                ExtraCost = 3.25f,
                Category = 3
            },
            new Ingredient
            {
                Id = 31,
                PriceId = "price_1MaPmyBCj4yzLlBMrJ0oyeA3",
                Name = "Pico de Gallo",
                ExtraCost = 3.50f,
                Category = 3
            },
            new Ingredient
            {
                Id = 32,
                PriceId = "price_1MaPnQBCj4yzLlBMVzBDmzJj",
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
                    PriceId = "price_1MaPnsBCj4yzLlBMfQCsVJ8X",
                    Name = "Fries",
                    Price = 5.50f

                },
                new MenuItem
                {
                    Id = 2,
                    PriceId = "price_1MaPo7BCj4yzLlBMycWmVeF8",
                    Name = "Poutine",
                    Price = 7.50f
                },
                new MenuItem
                {
                    Id = 3,
                    PriceId = "price_1MaPoSBCj4yzLlBMKNvdC857",
                    Name = "Chicken Nuggets",
                    Price = 6.50f
                },
                new MenuItem
                {
                    Id = 4,
                    PriceId = "price_1MaPonBCj4yzLlBMzSJeAZ62",
                    Name = "Onion Rings",
                    Price = 6.00f
                },
                new MenuItem
                {
                    Id = 5,
                    PriceId = "price_1MaPp6BCj4yzLlBMKCSQRMmJ",
                    Name = "Fried Pickles",
                    Price = 5.50f
                },
                new MenuItem
                {
                    Id = 6,
                    PriceId = "price_1MaPpSBCj4yzLlBMEm25nirQ",
                    Name = "Cheese Sticks",
                    Price = 7.00f
                },
                new MenuItem
                {
                    Id = 7,
                    PriceId = "price_1MaPphBCj4yzLlBMrDEHrEhL",
                    Name = "Pepsi",
                    Price = 3.50f
                },
                new MenuItem
                {
                    Id = 8,
                    PriceId = "price_1MaPq3BCj4yzLlBMnX2HqA1t",
                    Name = "7-Up",
                    Price = 3.50f
                },
                new MenuItem
                {
                    Id = 9,
                    PriceId = "price_1MaPqIBCj4yzLlBMawfkvOz9",
                    Name = "Iced Tea",
                    Price = 3.50f
                },
                new MenuItem
                {
                    Id = 10,
                    PriceId = "price_1MaPqhBCj4yzLlBM2XCTsEuI",
                    Name = "Dom Perignon Brut Champagne",
                    Price = 214.97f
                },
                new MenuItem
                {
                    Id = 11,
                    PriceId = "price_1MaPqzBCj4yzLlBMFOXHgZ8Y",
                    Name = "Celebrity Appearance",
                    Price = 999.99f
                },
                new MenuItem
                {
                    Id = 12,
                    PriceId = "price_1MaPrFBCj4yzLlBMArtP1kyt",
                    Name = "24 Karat Gold Leaf",
                    Price = 15.00f
                },
                new MenuItem
                {
                    Id = 13,
                    PriceId = "price_1MaPraBCj4yzLlBM8bXl4M1q",
                    Name = "Glenfarclas Single Malt 25",
                    Price = 199.99f
                },
                new MenuItem
                {
                    Id = 14,
                    PriceId = "price_1MaPrvBCj4yzLlBMIXo4gjjh",
                    Name = "Diner avec Jay-Z",
                    Price = 500000.00f
                },

                new MenuItem
                {
                    Id = 15,
                    Name = "La Basique",
                    PriceId = "price_1MaPsEBCj4yzLlBMpqrhKWIc",
                    Price = 29.25f,
                    Description = "Brioche Bread, Angus Beef, Lettuce, Tomatoes, Pickles, Ketchup, Mustard Relish"

                },
                new MenuItem
                {
                    Id = 16,
                    PriceId = "price_1MaPstBCj4yzLlBM2znngda6",
                    Name = "Le Fumé",
                    Price = 31.99f,
                    Description = "Sesame Seed Brioche, Angus Beef, Caramelized Onions, Mushrooms, Cheddar Cheese, Bacon, Barbecue Sauce"
                },
                new MenuItem
                {
                    Id = 17,
                    PriceId = "price_1MaPtLBCj4yzLlBM1hgrbgkg",
                    Name = "La Volaille",
                    Price = 24.50f,
                    Description = "Poppy Seed Brioche, Fried Chicken, Lettuce, Tomatoes, Goat Cheese, Spicy Mayonnaise"
                },
                 new MenuItem
                 {
                     Id = 18,
                     PriceId = "price_1MaPtqBCj4yzLlBMJx1PeQ7I",
                     Name = "La Piscicole",
                     Price = 22.50f,
                     Description = "Ciabatta, Fish Cake, Lettuce, Tomatoes, Pickles, Tartar Sauce"
                 },
                 new MenuItem
                 {
                     Id = 19,
                     PriceId = "price_1MaPvIBCj4yzLlBMUP2Hok64",
                     Name = "Le Champignon",
                     Price = 31.25f,
                     Description = "Poppy Seed Brioche, Portobello, Lettuce, Tomatoes, Pickles, Red Onions, Ketchup, Mustard, Relish"
                 },
                new MenuItem
                {
                    Id = 20,
                    PriceId = "price_1MaPviBCj4yzLlBMkqVdH1BL",
                    Name = "La Pastourelle",
                    Price = 35.75f,
                    Description = "Sesame Seed Brioche, Bison Patty, Lettuce, Tomatoes, Pickles, Caramelized Onions, Swiss Cheese, Mustard, Mayonnaise"
                },
                new MenuItem
                {
                    Id = 21,
                    PriceId = "price_1MaPwFBCj4yzLlBMh5323pJ9",
                    Name = "Le Mex",
                    Price = 31.75f,
                    Description = "Brioche, Angus Beef, Lettuce, Tomatoes, Pickles, Jalapeno Monterey Jack, Pico de Gallo, Guacamole"
                }
            );
            return modelBuilder;
        }
    }
}