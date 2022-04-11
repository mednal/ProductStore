using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Category
    {
        List<Product> products { get; set;}
        public  int CategoryId { get; set; }
        public  String Name { get; set; }
    }
}
