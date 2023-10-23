using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Product
    {
        public string Name;
        public int Count, Price;
        //dodawanie i usuwanie ilosci produktow:
        //object.Count = value
        public string Dane
        {
            get
            {
                return $"{Name} {Price}zł {Count}\n{Count*Price}zł";
            }
        }
        public Product(string name, int count, int price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
