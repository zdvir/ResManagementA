using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManagement.Classes
{
    class Order
    {
        public int TableID { get; set; }
        public String Employee { get; set; }
        public String ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Order(int tableId, String employee, String product, int quantity, int price)
        {
            TableID = tableId;
            Employee = employee;
            ProductName = product;
            Quantity = quantity;
            Price = price;
        }
    }
}
