using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Driven_Development___TDD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public bool Equals(Product produtoPorComparar)
        {
            if (this.Id    == produtoPorComparar.Id   & 
                this.Nome  == produtoPorComparar.Nome & 
                this.Valor == produtoPorComparar.Valor)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}