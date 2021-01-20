using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi  --->   " + customer.name + " " + customer.surname);
            Console.WriteLine("Eklenen ID   --->   " + customer.ID);
            Console.WriteLine("-------------------------------------------------");
            customers.Add(customer);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi   --->   " + customer.name + " " + customer.surname);
            Console.WriteLine("Silinen ID   --->   " + customer.ID);
            Console.WriteLine("-------------------------------------------------");
            customers.Remove(customer);
        }
        public void Listele()
        {
            Console.WriteLine("Müşteriler:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.name + " " + customer.surname);
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
