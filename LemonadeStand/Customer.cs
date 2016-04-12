using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {

        public int customerNumbers;
        public int customerMoods;
        public int getCustomerNumber;
        public List<int> customers = new List<int>();
        public Customer()
        {

        }
        
        public void GenerateCustomers()
        {
            Random GetCustomerNumbers = new Random();
            
                customerNumbers = GetCustomerNumbers.Next(70, 120);            

            for (int i = 0; i < customerNumbers; i++)
            {
                Random GetCustomerMoods = new Random();
                
                    customerMoods = GetCustomerMoods.Next(1, 6);
                    Thread.Sleep(20);
                    customers.Add(customerMoods);

                
            }

            //Console.WriteLine(customers.Count);   // No need to print customer moods
            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(customers.Count+" "+customers.);

        }
        


    }
}
