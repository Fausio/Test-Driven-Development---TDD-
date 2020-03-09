using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Driven_Development___TDD.Models
{
    public class Carinho_de_compra
    {

        public  List<Product> Products = new List<Product>();

        public void  Add_Product(Product product)
        {
            this.Products.Add(product); 
        }
    }
}