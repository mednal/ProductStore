using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider :Concept
        
    {

        public List<Product> Products { get; set; }

       /* public String confirm ;*/
     /*   public String ConfirmePaswword { get { return confirm; } 
            set 
            { if (!value.Equals(Password))
                    Console.WriteLine( "please write the same password");
                else Console.WriteLine("Done");
            }
        }*/
    /*    public String password;*/
        public String DateCreated { get; set; }
       public String Email { get; set; }
        public int Id {get;set;}

        public Boolean IsApproved;
        /*     public String Password
             {
                 get { return password; }
                 set
                 {
                     if (value.Length < 5) Console.WriteLine("passwor should be ..."); else password=value;
                 }
             }*/
        public String Password { get; set; }
        public String ConfirmePassword{ get; set; }
        


        /*    public String Password{get { return password;}
                set{if (value.Length > 20 || value.Length < 5) Console.WriteLine("please write a valid password");
                    else password = value; }}*/
        public String UserName{ get; set; }



        public static void SetIsApproved(Provider pr)
        {
            pr.IsApproved = pr.Password.Equals(pr.ConfirmePassword);
        }

      /*  public static void SetIsApproved(String password,String confirm, bool isaproved) {
            isaproved = String.Compare(password, confirm) ==0;
        
        }
*/
        public Boolean Login(String nom,String pwd)
        {
            return UserName.Equals(nom) && Password.Equals(pwd);

        }

        //hedhi fi 3oudh ezouz 
     /*    public Boolean Login(String nom,String pwd,String email)
        {
            if (String.Equals(nom, UserName)&&String.Equals(pwd,Password)&& String.Equals(email, email))
            {
                return true;
            }
            return false;
        }*/

        public Boolean Login(String nom, String pwd, String email=null)
        {
            if (String.Equals(nom, UserName) && String.Equals(pwd, Password) && String.Equals(email, email))
            {
                return true;
            }
            return false;
        }


        public  void GetProducts(String filterType,String filterValue) 
        {

            List<Product> listp = new List<Product>();
            switch(filterType)
            {
                case "Quantity":
                    foreach(Product p in listp)
                    { if (p.Quantity==double.Parse(filterValue))
                            Console.WriteLine(p);                     
                    }

                   break;


                case "Name":

                    foreach (Product p in listp)
                    {
                        if (p.Name==filterValue)
                            Console.WriteLine(p);
                    }
                    break;
            }


            

        }
 public static void Calculer(int a,int b,ref int c) {
            c = a + b;
        }

        public override void GetDetails()
        {
            Console.WriteLine("Nom"+UserName);
            for(int i = 0; i < Products.Count; i++) 
            {
                Console.WriteLine(Products[i]);
            }
            
        }
    }
   
}
