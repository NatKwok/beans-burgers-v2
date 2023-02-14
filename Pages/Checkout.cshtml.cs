using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Azure.Storage.Blobs;
using System.Text;

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
        public OrderDetails OrderDetails {get; set;} = new OrderDetails();
        public int totalItems {get; set;} = 0;
        public double totalPrice {get; set;} =0;
        public double totalTax {get; set;} = 0;
        public double grandTotal {get; set;} = 0;

        public async Task<IActionResult> OnGetAsync(){
            OrderItems = await db.OrderItems.ToListAsync();
            
            CalcTotals();
            OrderDetails.OrderItemsList = OrderItems;
            OrderDetails.totalItems = totalItems;
            OrderDetails.totalPrice = totalPrice;
            OrderDetails.totalTax = totalTax;
            OrderDetails.grandTotal = grandTotal;

            
           return Page(); 
        }

        public async Task<IActionResult> OnPostAsync() {
        //Send OrderItems to database
            OrderItems = await db.OrderItems.ToListAsync();
            CalcTotals();
            OrderDetails.OrderItemsList = OrderItems;
            OrderDetails.totalItems = totalItems;
            OrderDetails.totalPrice = totalPrice;
            OrderDetails.totalTax = totalTax;
            OrderDetails.grandTotal = grandTotal;

            db.OrdersDetails.Add(OrderDetails);
            db.SaveChanges();

        //Send Receipt String to Blob
            string dataString = OrderDetails.ToString();
            //Set up the blob connection
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=beansburgersblobs;AccountKey=aIWyiqsEk6SOUkU7+mTdMkTZtyMzVUuTYVnAyyFJYwhmpaWejxjC3nbQoDY+wkuCl1gmLTCC77zV+AStC1YVBw==;EndpointSuffix=core.windows.net";
            string storageContainer = "beansburgers";
            BlobContainerClient container = new BlobContainerClient(connectionString, "order");
            //Send string to blob
            BlobClient blob = container.GetBlobClient(dataString);
            var content = Encoding.UTF8.GetBytes(dataString);
            using(var ms = new MemoryStream(content))
                blob.Upload(ms, overwrite: true);
            
            /*double totalPrice = 0;
            for(int i = 0; i < db.OrderItems.ToList().Count(); i++) {
                dataString = string.Concat(dataString, db.OrderItems.ToList()[i].CustomBurger + " = " + db.OrderItems.ToList()[i].BurgerPrice + " x " + db.OrderItems.ToList()[i].Quantity + "\n");
                totalPrice += (db.OrderItems.ToList()[i].BurgerPrice * db.OrderItems.ToList()[i].Quantity);
            }
            double totalTax = totalPrice * 0.15;
            totalPrice *= 1.15;   
            dataString = string.Concat(dataString, "Total tax = " + totalTax + "\n");
            dataString = string.Concat(dataString, "Total price = " + totalPrice);*/       
            return RedirectToPage("CheckoutConfirmation", new{id = OrderDetails.Id} );
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
