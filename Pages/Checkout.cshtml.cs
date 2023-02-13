using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Azure.Storage.Blobs;

namespace BeansBurgers_v2.Pages
{
    public class CheckoutModel : PageModel
    {
        private ApplicationDbContext db;
        public string Id { get; set; }
        public CheckoutModel(ApplicationDbContext db) => this.db = db;
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
        public OrderItem OrderItem { get; set;}

        public async Task<IActionResult> OnGetAsync(){
            OrderItems = await db.OrderItems.ToListAsync();
            string dataString = "";
            double totalPrice = 0;
            for(int i = 0; i < db.OrderItems.ToList().Count(); i++) {
                dataString = string.Concat(dataString, db.OrderItems.ToList()[i].CustomBurger + " = " + db.OrderItems.ToList()[i].BurgerPrice + " x " + db.OrderItems.ToList()[i].Quantity + "\n");
                totalPrice += (db.OrderItems.ToList()[i].BurgerPrice * db.OrderItems.ToList()[i].Quantity);
            }
            totalPrice *= 1.15;   
            dataString = string.Concat(dataString, "Total price = " + totalPrice);
            System.IO.File.WriteAllText("../AppIIBeansBurgers_v2/Receipts/Order.txt", dataString);
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=beansburgersblobs;AccountKey=aIWyiqsEk6SOUkU7+mTdMkTZtyMzVUuTYVnAyyFJYwhmpaWejxjC3nbQoDY+wkuCl1gmLTCC77zV+AStC1YVBw==;EndpointSuffix=core.windows.net";
            string storageContainer = "beansburgers";
            BlobContainerClient azContainer = new BlobContainerClient(connectionString, storageContainer);
            string fileName = Path.GetFileName("../AppIIBeansBurgers_v2/Receipts/Order.txt");
            BlobClient blobClient = azContainer.GetBlobClient(fileName);
            await blobClient.UploadAsync("../AppIIBeansBurgers_v2/Receipts/Order.txt", true);
            return RedirectToPage("Menu");
        }

        public async Task<IActionResult> OnPostAsync() {

            OrderItem = await db.OrderItems.FindAsync(Id);

            var body = $@"<p>Item Name: {OrderItem.CustomBurger} 
                        <br>Price: ${OrderItem.BurgerPrice}
                        <br>Quantity: {OrderItem.Quantity} 
                        <br>Description: {OrderItem.Description}
                            </p>";
            
           
            return RedirectToPage("Index");
        }
    }
}
