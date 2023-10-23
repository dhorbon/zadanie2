using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    public class Bank
    {
        public string Nazwa, Adres;
        public List<Client> clients;

        /*
        ** Dodawanie klientow: object.clients.Add(object)
        ** Usuwanie klientów:  object.clients.Remove(object)
        ** lub: object.clients.RemoveAt(index)
        */

        public void Client(int i)
        {
            Console.WriteLine(clients[i].Dane);
        }

        public void Clients()
        {
            for(int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine(clients[i].Dane);
            }
        }

        public Bank(string nazwa, string adres)
        {
            Nazwa = nazwa;
            Adres = adres;
            clients = new List<Client>();
        }
    }
}
