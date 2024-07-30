using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSample
{
    public class OrderInfo
    {
        private int orderID;
        private string name;
        private string customer;
        private string shipCity;
        private string shipCountry;
        private bool? isOnline;
        private int orderID1;
        private string customerID1;
        private string customer1;
        private string shipCity1;
        private string shipCountry1;
        private bool? isOnline1;
        private string orderID2;
        private string customerID2;
        private string customer2;
        private string shipCity2;
        private string shipCountry2;
        private bool? isOnline2;

        public int OrderID
        {
            get { return orderID; }
            set { this.orderID = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; }
        }        

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { this.shipCity = value; }
        }

        public bool? IsOnline
        {
            get { return isOnline; }
            set { isOnline = value; }
        }

        public int OrderID1
        {
            get { return orderID1; }
            set { this.orderID1 = value; }
        }

        public string CustomerID1
        {
            get { return customerID1; }
            set { this.customerID1 = value; }
        }

        public string ShipCountry1
        {
            get { return shipCountry1; }
            set { this.shipCountry1 = value; }
        }

        public string Customer1
        {
            get { return this.customer1; }
            set { this.customer1 = value; }
        }

        public string ShipCity1
        {
            get { return shipCity1; }
            set { this.shipCity1 = value; }
        }

        public bool? IsOnline1
        {
            get { return isOnline1; }
            set { isOnline1 = value; }
        }

        public string OrderID2
        {
            get { return orderID2; }
            set { this.orderID2 = value; }
        }

        public string CustomerID2
        {
            get { return customerID2; }
            set { this.customerID2 = value; }
        }

        public string ShipCountry2
        {
            get { return shipCountry2; }
            set { this.shipCountry2 = value; }
        }

        public string Customer2
        {
            get { return this.customer2; }
            set { this.customer2 = value; }
        }

        public string ShipCity2
        {
            get { return shipCity2; }
            set { this.shipCity2 = value; }
        }

        public bool? IsOnline2
        {
            get { return isOnline2; }
            set { isOnline2 = value; }
        }
        public OrderInfo(int orderId, string customerId, string country, string customer, string shipCity, bool isOnline, int orderId1, string customerId1, string country1, string customer1, string shipCity1, bool isOnline1, string orderId2, string customerId2, string country2, string customer2, string shipCity2,bool isOnline2)
        {
            this.OrderID = orderId;
            this.Name = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
            this.IsOnline = isOnline;
            this.OrderID1 = orderId1;
            this.CustomerID1 = customerId1;
            this.Customer1 = customer1;
            this.ShipCountry1 = country1;
            this.ShipCity1 = shipCity1;
            this.IsOnline1 = isOnline1;
            this.OrderID2 = orderId2;
            this.CustomerID2 = customerId2;
            this.Customer2 = customer2;
            this.ShipCountry2 = country2;
            this.ShipCity2 = shipCity2;
            this.IsOnline2 = isOnline2;

        }
    }
}
