using System;

namespace MyCompiler {
    
       class Product{
            public int id;    
            public string name;
           public double price;
           
          
       }
    
    class Program {
        public static void Main(string[] args) {
          
     
             Product p1=new Product();
             p1.id=1;
             p1.name="car";
             p1.price=30;
           
             
             
          
          
          Console.WriteLine("id/tname/tprice");
         Console.WriteLine(p1.id+"/t"+p1.name+"/t"+p1.price);
          
           }
   }
}