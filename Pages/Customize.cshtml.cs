using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BeansBurgers_v2.Pages
{
    public class CustomizeModel : PageModel
    {
        private ApplicationDbContext _db;
        // public CustomizeModel(ApplicationDbContext db) => this.db = db;

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        // public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();  
        public MenuItem MenuItem {get; set;}
        public BunsEnum Buns {get; set;}
        public PattiesEnum Patties {get; set;}
        public CheeseEnum Cheese {get; set;}
        public SauceEnum Sauce {get; set;}
        public ToppingsEnum Toppings {get; set;}

        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        

        public CustomizeModel(ApplicationDbContext db)  
        {  
            _db = db;  
        }
        
        public async Task OnGetAsync() {

            OrderItems = await _db.OrderItems.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync() {

            string description = "";
            string buns = Request.Form["buns"];
            if(buns != null){
                description = string.Concat(description, buns + " bun, ");
            }
            
            string Angus = Request.Form["Angus"];
            if(Angus != null){
                description = string.Concat(description, Angus + " angus beef, ");
            }

            string Fried_Chicken = Request.Form["Fried_Chicken"];
            if(Fried_Chicken != null){
                description = string.Concat(description, Fried_Chicken + " fried chicken, ");
            }

            string Fish_Cake = Request.Form["Fish_Cake"];
            if(Fish_Cake != null){
                description = string.Concat(description, Fish_Cake + " fish cake, ");
            }

            string Bison = Request.Form["Bison"];
            if(Bison != null){
                description = string.Concat(description, Bison + " bison, ");
            }

            string Beyond_Meat = Request.Form["Beyond_Meat"];
            if(Beyond_Meat != null){
                description = string.Concat(description, Beyond_Meat + " beyond meat, ");
            }

            string Portobello = Request.Form["Portobello"];
            if(Portobello != null){
                description = string.Concat(description, Portobello + " portobello, ");
            }

            string Lettuce = Request.Form["Lettuce"];
            if(Lettuce != null){
                description = string.Concat(description, Lettuce + " Lettuce, ");
            }

            string Tomatoes = Request.Form["Tomatoes"];
            if(Tomatoes != null){
                description = string.Concat(description, Tomatoes + " Tomatoes, ");
            }

            string Pickles = Request.Form["Pickles"];
            if(Pickles != null){
                description = string.Concat(description, Pickles + " Pickles, ");
            }

            string Red_Onions = Request.Form["Red_Onions"];
            if(Red_Onions != null){
                description = string.Concat(description, Red_Onions + " Red Onions, ");
            }

            string Caramelized_Onions = Request.Form["Caramelized_Onions"];
            if(Caramelized_Onions != null){
                description = string.Concat(description, Caramelized_Onions + " Caramelized Onions, ");
            }

            string Mushrooms = Request.Form["Mushrooms"];
            if(Mushrooms != null){
                description = string.Concat(description, Mushrooms + " Mushrooms, ");
            }

            string Banana_Peppers = Request.Form["Banana_Peppers"];
            if(Banana_Peppers != null){
                description = string.Concat(description, Banana_Peppers + " Banana Peppers, ");
            }

            string Jalepeno_Monterey_Jack = Request.Form["Jalepeno_Monterey_Jack"];
            if(Jalepeno_Monterey_Jack != null){
                description = string.Concat(description, Jalepeno_Monterey_Jack + " Jalepeno Monterey Jack, ");
            }

            string Swiss = Request.Form["Swiss"];
            if(Swiss != null){
                description = string.Concat(description, Swiss + " Swiss cheese, ");
            }

            string Goat_Cheese = Request.Form["Goat_Cheese"];
            if(Goat_Cheese != null){
                description = string.Concat(description, Goat_Cheese + " Goat Cheese, ");
            }   

            string Ketchup = Request.Form["Ketchup"];
            if(Ketchup != null){
                description = string.Concat(description, Ketchup + " Ketchup, ");
            }

            string Mustard = Request.Form["Mustard"];
            if(Mustard != null){
                description = string.Concat(description, Mustard + " Mustard, ");
            }

            string Relish = Request.Form["Relish"];
            if(Relish != null){
                description = string.Concat(description, Relish + " Relish, ");
            }

            string Mayo = Request.Form["Mayo"];
            if(Mayo != null){
                description = string.Concat(description, Mayo + " Mayo, ");
            }

            string Spicy_Mayo = Request.Form["Spicy_Mayo"];
            if(Spicy_Mayo != null){
                description = string.Concat(description, Spicy_Mayo + " Spicy Mayo, ");
            }

            string Tartar_Sauce = Request.Form["Tartar_Sauce"];
            if(Tartar_Sauce != null){
                description = string.Concat(description, Tartar_Sauce + " Tartar Sauce, ");
            }

            string BBQ = Request.Form["BBQ"];
            if(BBQ != null){
                description = string.Concat(description, BBQ + " BBQ sauce, ");
            }

            string Pico_de_Gallo = Request.Form["Pico_de_Gallo"];
            if(Pico_de_Gallo != null){
                description = string.Concat(description, Pico_de_Gallo + " Pico de Gallo, ");
            }

            string Guacamole = Request.Form["Guacamole"];
            if(Guacamole != null){
                description = string.Concat(description, Guacamole + " Guacamole, ");
            }


            int qty = Int32.Parse(Request.Form["Quantity"]);
            
            int separatorIndex = Id.IndexOf(',');
            ItemId = Int32.Parse(Id.Substring(0, separatorIndex));
            ItemName = Id.Substring(separatorIndex + 1);
            MenuItem add;
            double price = 0;
            for(int i = 0; i < _db.MenuItems.ToList().Count(); i++){
                if(_db.MenuItems.ToList()[i].Name == ItemName){
                    add = _db.MenuItems.ToList()[i];
                    price = _db.MenuItems.ToList()[i].Price;
                }
            }
            OrderItem item = new OrderItem() { CustomBurger = ItemName, Description = description, Quantity=qty, BurgerPrice = (float)price};
            _db.OrderItems.Update(item);
            _db.SaveChanges();

            return RedirectToPage("Delete", new {id = ItemId});
        }

    }
}
