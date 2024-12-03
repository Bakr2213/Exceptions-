using System;

namespace Exceptions
{
    class Program
    {

        static void Main(string[] args)
        {
            var delivery = new Delivery { Id = 1253, CustomerName = "Abdo Bakr", Adress = "32 Staduim street" };
            var Service = new DeliveryService();
            Service.Start(delivery);
            Console.WriteLine(delivery);


            Console.ReadKey();
        }
      
    }
}