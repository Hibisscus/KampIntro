using System;
//poliformizim=çok biçimlilik

namespace OOP2
{
    class Program
    {


        static void Main(string[] args)
        {
;
            IndividualCustomer customer1 = new IndividualCustomer();

            customer1.CustomerNo = "123";
            customer1.Name = "Can";
            customer1.Surname = "Szr";
            customer1.TcNo = "99999999999";
            customer1.Id = 1;


            CorporateCustomer customer2 = new CorporateCustomer();

            customer2.Id = 2;
            customer2.TaxNo = "4576251";
            customer2.CompanyName = "Kemer";
            customer2.CustomerNo = "98745";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);  
        }

    }
}
