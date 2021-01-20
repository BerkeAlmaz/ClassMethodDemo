using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.name = "Berke";
            customer1.surname = "Almaz";
            customer1.age = 16;
            customer1.ID = "12485785649";

            Customer customer2 = new Customer();
            customer2.name = "Ali";
            customer2.surname = "Yılmaz";
            customer2.age = 45;
            customer2.ID = "45632198755";

            Customer customer3 = new Customer();
            customer3.name = "Bura";
            customer3.surname = "Dıroğlu";
            customer3.age = 88;
            customer3.ID = "63897451278";

            Customer customer4 = new Customer();
            customer4.name = "Duna";
            customer4.surname = "Üzkan";
            customer4.age = 94;
            customer4.ID = "15798564571";

            Customer customer5 = new Customer();
            customer5.name = "Burxu";
            customer5.surname = "Slefusz";
            customer5.age = 18;
            customer5.ID = "15498567452";

            Customer[] customers = new Customer[] { customer1, customer3, customer5 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);
            customerManager.Add(customer5);
            customerManager.Delete(customer4);
            customerManager.Delete(customer2);
            customerManager.Listele(customers);
        }
    }
}
