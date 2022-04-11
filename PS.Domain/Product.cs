using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    //seald class ne peut pas etre herité
    public class Product
    {
        /*
        public Product(List<Provider> providers, Category category, int quantity, int idProduct, DateTime dateProd, string description, string name, double price)
        {
            this.providers = providers;
            this.category = category;
            Quantity = quantity;
            IdProduct = idProduct;
            DateProd = dateProd;
            Description = description;
            Name = name;
            Price = price;
        }
        */
        List<Provider> providers { get; set; }
       public Category category { get; set;}
        public  int Quantity {  get; set;}
        public int IdProduct { get;set; }
        public DateTime DateProd { get ; set ; }
        public string Description { get;set ;}
        public string Name { get ; set ;}
        public double Price { get ; set ;}

        public override string ToString()
        {
            return "Name\n"  +Name+ " Price "+Price+"Date"+DateProd;
        }
       
        
        public virtual void GetMyType()
        {
            Console.WriteLine("produit");
        }
    }
    
}
