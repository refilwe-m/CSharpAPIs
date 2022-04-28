using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using CoffeeShop.File;

namespace CoffeeShop.Controllers
{
    [Produces("application/json")]
    [ApiController]
    //[Route("api/[controller]/[action]")]
    public class CoffeeShopController
    {
        [HttpGet]
        public static string GetAllOrders()
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
        public static string GetAllCustomers()
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
        public static string GetAllBaristas()
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
        public static int CountAllAfricans()
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
        public static int CountAllOrders()
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
        public static int CountAllCoustomers()
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
        public static int CountAllBaristas()
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
        public static int CountAllWhites()
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
        public static int CountAllBirthdays(int month)
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
        //save to file
        public static void SaveToFile(string fileName, string data)
        {
            FileIO.SaveToFile(data);

        }

        [HttpPost]
        public static string AddOrder([FromBody] Order order)
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
        public static string AddCustomer([FromBody] Customer customer)
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
        public static string AddBarista([FromBody] Barista barista)
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
        public static string DeleteOrder(int id)
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
        public static string DeleteCustomer(int id)
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
        public static string DeleteBarista(int id)
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
        public static string UpdateOrder([FromBody] Order order, int id)
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
        public static string UpdateCustomer([FromBody] Customer customer, int id)
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
        public static string UpdateBarista([FromBody] Barista barista, int id)
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
    public class Order
    {
        public int CustomerID { get; set; }

        public string CoffeeName { get; set; }
        public int Quantity { get; set; }
        public int CoffeePrice { get; set; }
        public int BaristaID { get; set; }

        //public string OrderDate { get; set; }
        //public string OrderTime { get; set; }  
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string Race { get; set; }
        public string Email { get; set; }
    }

    public class Barista
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Rating { get; set; }

    }
}