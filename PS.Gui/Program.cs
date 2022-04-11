using PS.Domain;
using System;
using System.Collections.Generic;
namespace PS.Gui
{
    class Program
    {


        static void Main(string[] args)
        {
           

           


            Provider provid = new Provider();
            Product p = new Product();
            Product pr = new Product()
            {
                Name = "ps5", Quantity = 40
            };

            Product p1= new Product()
            {
                Name = "dele3",
          

            };


            Product p2 = new Product()
            {
                Name = "tefe7",
                

            };
            List<Product> plist = new List<Product>
            {
             p1,p2
            };
            Console.WriteLine("hahaha");
            provid.Products = plist;
            provid.GetDetails();

            /* plist.Add(p2);*/

          

            Provider prov = new Provider()
            {
                Password = "123456",
               ConfirmePassword= "123456",
               Email="mednal@gmail.com",
               UserName= "aaaaaaa"
            };
          

            Console.WriteLine("//////////////////");
            Console.WriteLine("Login test");
            Console.WriteLine(prov.Login("aaaaaaa", "123456"));
            Console.WriteLine("setIsapproved");
     Provider.SetIsApproved(prov);
            Console.WriteLine(prov.IsApproved);

            Console.WriteLine("//////////////////");
            int i = 5;
            int j = 3;
            int k = 2;

            Provider.Calculer(i, j,  ref k);
            Console.WriteLine(k);
            Console.WriteLine(pr);
            // System.Console.ReadKey();

            /*        
                    Console.WriteLine(pr.Name);
                    p.Name = "Fraise";
                    p.DateProd = new DateTime(2002, 12, 1);
                    p.DateProd =  DateTime.Now;
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.DateProd);
                    Console.WriteLine("Ahla wa Sahla");
            */

            Console.WriteLine("//////////////////");

            Biological b = new Biological();
            b.GetMyType();
            Chemical c = new Chemical();
            c.GetMyType();

            Console.WriteLine("//////////////////");
            //Provider.SetIsApproved(prov);

            Console.WriteLine("//////////////////");

            Product prod = new Product();
            Chemical ch = new Chemical();
            Biological  BIO= new Biological();
            Console.WriteLine( "aaaaaaaaaaa");
            ch.GetMyType();

            Console.WriteLine("//////////////////");


            p1.Price = 4000;
            p2.Price = 405;
            Console.WriteLine("wawawawawa");
            prov.GetProducts("Name", "dele3");

        }




    }
}



