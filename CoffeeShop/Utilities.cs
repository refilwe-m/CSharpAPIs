namespace CoffeeShop.Utilities
{
    public class Order
    {
        public int CustomerID { get; set; }

        public string CoffeeName
        { get; set; }
        public int Quantity { get; set; }
        public double CoffeePrice { get; set; }
        public int BaristaID { get; set; }

        //public string OrderDate { get; set; }
        //public string OrderTime { get; set; }  
    }

    public class Customer
    {
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public int BirthDay
        { get; set; }
        public int BirthMonth
        { get; set; }
        public string Race
        { get; set; }
        public string Email
        { get; set; }
    }

    public class Barista
    {
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }

        public int Rating { get; set; }

    }

}