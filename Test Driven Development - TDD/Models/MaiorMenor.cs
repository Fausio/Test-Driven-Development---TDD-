using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Driven_Development___TDD.Models
{
    public class MaiorMenor
    {
        public Product Menor { get; set; }
        public Product Maior { get; set; }

        public void Buscar(Carinho_de_compra carinho_De_Compra)
        {
            foreach (Product product in carinho_De_Compra.Products)
            {
                if (Menor == null || product.Valor < Menor.Valor)
                {
                    Menor = product;
                }
                if (Maior == null || product.Valor > Maior.Valor)
                {
                    Maior = product;
                }
            }

        }

    }
}