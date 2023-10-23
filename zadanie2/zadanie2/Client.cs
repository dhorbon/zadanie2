using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    public class Client
    {
        public string Name, Surname, Phone, Address;
        public string Dane
        {
            get { return $"{Name} {Surname} {Phone} {Address}"; }
        }

        public Client(string Name, string Surname, string Phone, string Address)
        {
            this.Name = Name ;
            this.Surname = Surname ;
            this.Phone = Phone ;
            this.Address = Address ;
        }
    }
}