using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Car
    {
        public string Brand, ProductionYear, Price;
        public List<string> Models;
            
        public string NewModel
        {
            set { Models.Add(value); }
        }

        public void DeleteModel(string model)
        {
            Models.Remove(model);
        }

        public string Dane
        {
            get 
            {
                string temp = $"{Brand} {ProductionYear} {Price}";
                for(int i  = 0; i < Models.Count; i++)
                {
                    temp += $" {Models[i]}";
                }
                return temp;
            }
        }

        public Car(string brand, string prodYear, string price)
        {
            Brand = brand;
            ProductionYear = prodYear;
            Price = price;
            Models = new List<string>();
        }
    }
}
