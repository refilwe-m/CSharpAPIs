using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using CoffeeShop.File;
using CoffeeShop.Utilities;

namespace CoffeeShop.Controllers
{
    [Produces("application/json")]
    [ApiController]

    public class CoffeeShopController
    {
        [HttpGet]
        public static string GGetAllOrders()
        {
            try
            {
                return CoffeeShopQuery.GetAllData("Orders");

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }

        }

        [HttpGet]
        public static string GGetAllCustomers()
        {
            try
            {
                return CoffeeShopQuery.GetAllData("Customers");

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpGet]
        public static string GGetAllBaristas()
        {
            try
            {
                return CoffeeShopQuery.GetAllData("Baristas");

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpGet]
        public static int GCountAllAfricans()
        {
            try
            {
                CoffeeShopQuery.CountAllAfricans();
                return int.Parse(CoffeeShopQuery.sqlResult);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return -1;
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }

        }

        [HttpGet]
        public static int GCountAllOrders()
        {
            try
            {
                CoffeeShopQuery.CountAllOrders();
                return int.Parse(CoffeeShopQuery.sqlResult);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return -1;
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpGet]
        public static int GCountAllCoustomers()
        {
            try
            {
                CoffeeShopQuery.CountAllCustomers();
                return int.Parse(CoffeeShopQuery.sqlResult);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return -1;
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpGet]
        public static int GCountAllBaristas()
        {
            try
            {
                CoffeeShopQuery.CountAllBaristas();
                return int.Parse(CoffeeShopQuery.sqlResult);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return -1;
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpGet]
        public static int GCountAllWhites()
        {
            try
            {
                CoffeeShopQuery.CountAllWhites();
                return int.Parse(CoffeeShopQuery.sqlResult);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return -1;
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpGet]
        public static int GCountAllBirthdays(int month)
        {
            try
            {
                CoffeeShopQuery.CountAllBirthdays(month);
                return int.Parse(CoffeeShopQuery.sqlResult);

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return -1;
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpPost]
        public static void PSaveToFile()
        {
            string data = "{" + $"\n'African Coffee Lovers':'{GCountAllAfricans()}',\n'Orders':'{GCountAllOrders()}',\n'Customers':'{GCountAllCoustomers()}',\n'Baristas':'{GCountAllBaristas()}',\n'Whites':'{GCountAllWhites()},',\n'Birthdays':'{GCountAllBirthdays(1)}'" + "}";
            FileIO.SaveToFile(data.Replace("'", "\""));
        }

        [HttpPost]
        [Produces("application/json")]
        public static string PAddOrder([FromBody] CoffeeShop.Utilities.Order order)
        {
            try
            {
                CoffeeShopQuery.AddOrder(order);
                return "Order Added";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpPost]
        public static string PAddCustomer([FromBody] CoffeeShop.Utilities.Customer customer)
        {
            try
            {
                CoffeeShopQuery.AddCustomer(customer);
                return "Customer Added";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpPost]
        public static string PAddBarista([FromBody] CoffeeShop.Utilities.Barista barista)
        {
            try
            {
                CoffeeShopQuery.AddBarista(barista);
                return "Barista Added";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpDelete("{id}")]
        public static string DDeleteOrder(int id)
        {
            try
            {
                CoffeeShopQuery.DeleteOrder(id);
                return "Order Deleted";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpDelete("{id}")]
        public static string DDeleteCustomer(int id)
        {
            try
            {
                CoffeeShopQuery.DeleteCustomer(id);
                return "Customer Deleted";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpDelete("{id}")]
        public static string DDeleteBarista(int id)
        {
            try
            {
                CoffeeShopQuery.DeleteBarista(id);
                return "Barista Deleted";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpPut]
        public static string UUpdateOrder([FromBody] Order order, int id)
        {
            try
            {
                CoffeeShopQuery.UpdateOrder(order, id);
                return "Order Updated";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpPut]
        public static string UUpdateCustomer([FromBody] Customer customer, int id)
        {
            try
            {
                CoffeeShopQuery.UpdateCustomer(customer, id);
                return "Customer Updated";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

        [HttpPut]
        public static string UUpdateBarista([FromBody] Barista barista, int id)
        {
            try
            {
                CoffeeShopQuery.UpdateBarista(barista, id);
                return "Barista Updated";

            }
            catch (Exception)
            {
                Console.WriteLine("Error: {Exception.Message}");
                return "Error: {Exception.Message}";
            }
            finally
            {
                CoffeeShopQuery.Clear();
            }
        }

    }
    /* public class Order
    
    {
        public int CustomerID { get; set; }

        public string CoffeeName
        {
            get
            {
                return CoffeeName;
            }
            set
            {
                CoffeeName = value;
            }
        }
        public int Quantity { get; set; }
        public int CoffeePrice { get; set; }
        public int BaristaID { get; set; }

        //public string OrderDate { get; set; }
        //public string OrderTime { get; set; }  
    }

    public class Customer
    {
        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;

            }
        }
        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string BirthDay
        {
            get
            {
                return BirthDay;
            }
            set
            {
                BirthDay = value;
            }
        }
        public string BirthMonth
        {
            get
            {
                return BirthMonth;
            }
            set
            {
                BirthMonth = value;
            }
        }
        public string Race
        {
            get
            {
                return Race;
            }
            set { Race = value; }
        }
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
    }

    public class Barista
    {
        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }

        public int Rating { get; set; }

    }
 */
}