using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BeansBurgers_v2.Pages
{
    public class MenuModel : PageModel
    {
        public int Id {get; set;}
        private ApplicationDbContext db;
        public MenuModel(ApplicationDbContext db) => this.db = db;
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
        public MenuItem MenuItem {get; set;}
        public int totalItems {get; set;} = 0;
        public double totalPrice {get; set;} =0;
        public double totalTax {get; set;} = 0;
        public double grandTotal {get; set;} = 0;
        public OrderDetails OrderDetails {get; set;} = new OrderDetails();
        
        public async Task OnGetAsync(){

            Ingredients = await db.Ingredients.ToListAsync();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            MenuItem = await db.MenuItems.FindAsync(Id);
            CalcTotals();
            OrderDetails = new OrderDetails() {
                OrderItemsList = OrderItems,
                totalItems = totalItems,
                totalPrice = totalPrice,
                totalTax = totalTax,
                grandTotal = grandTotal

            };

        }

        public async Task<IActionResult> OnPostAsync(){
            Console.WriteLine("Post");
            string itemIndex = Request.Form["Order"];
            int itemInt = Int32.Parse(itemIndex);
            MenuItem add = db.MenuItems.ToList().ElementAt(itemInt - 1);

            OrderItem cartItem = new OrderItem { CustomBurger = add.Name, BurgerPrice = (float)add.Price, Quantity = 1 };
            db.OrderItems.Add(cartItem);
            db.SaveChanges();

            Console.WriteLine(MenuItems.Count);
        
            Ingredients = await db.Ingredients.ToListAsync();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            CalcTotals();

            OrderDetails.OrderItemsList = OrderItems;
            OrderDetails.totalItems = totalItems;
            OrderDetails.totalPrice = totalPrice;
            OrderDetails.totalTax = totalTax;
            OrderDetails.grandTotal = grandTotal;

            return Page();
        }

        public void CalcTotals() {
            if (OrderItems.Count > 0) {

                double taxRate = 0.15;
                foreach (var item in OrderItems)
                {
                  totalItems += item.Quantity;  
                  totalPrice += item.BurgerPrice * item.Quantity;  

                }

                totalTax = totalPrice * taxRate;
                grandTotal = totalTax + totalPrice;
            }
        }
        
    }

}
