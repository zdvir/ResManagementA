using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManagement.Classes
{
    class Product
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public int Stocks { get; set; }
        public byte[] Image{ get; set; }

        public Product(String id, String name, int stocks, int price,byte[] image)
        {
            Id = id;
            Name = name;
            Price = price;
            Stocks = stocks;
            Image = image;
        }

        public override String ToString()
        {
            return "Product Name: " + Name +"ID:"+Id+ " Price: " + Price + " Stocks: " + Stocks;
        }
    }


}
