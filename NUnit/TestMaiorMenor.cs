using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Driven_Development___TDD.Models;

namespace NUnit
{
    [TestFixture]
    class TestMaiorMenor
    {
        Product product_01 = new Product() { Id = 1, Nome = "lap-top", Valor = 30 };
        Product product_02 = new Product() { Id = 2, Nome = "bicileta", Valor = 20 };
        Product product_03 = new Product() { Id = 3, Nome = "Fugão a carvão", Valor = 10 };

        [Test]
        public void OrdemDecrescente()
        {
            // Esse trecho de codigo faz o teste  do maior, menor produto no carinho, onde os produtos estão agrupados de ordem decrescente, quanto ao seu valor 



            Carinho_de_compra carinho = new Carinho_de_compra();
            carinho.Add_Product(product_01);
            carinho.Add_Product(product_02);
            carinho.Add_Product(product_03);

            MaiorMenor algoritmo = new MaiorMenor();
            algoritmo.Buscar(carinho);


            // esse é o metodo que  dá o feedback se o teste foi feito com sucesso ou não 
            Assert.AreEqual("Fugão a carvão", algoritmo.Menor.Nome);
            Assert.AreEqual("lap-top", algoritmo.Maior.Nome);


            if ("Fugão a carvão" == algoritmo.Menor.Nome & "lap-top" == algoritmo.Maior.Nome)
            {
                Console.WriteLine("Teste maior e menor produto para produtos adicionados na carinha  do forma decrescente PASSOU !!!");
            }
            else
            {
                Console.WriteLine("Teste maior e menor produto para produtos adicionados na carinha  do forma decrescente NÂO PASSOU !!!");
            }
        }

        [Test]
        public void OrdernCrescente()
        {
            Carinho_de_compra carinho = new Carinho_de_compra();
            carinho.Add_Product(product_03);
            carinho.Add_Product(product_02);
            carinho.Add_Product(product_01);

            MaiorMenor algoritmo = new MaiorMenor();
            algoritmo.Buscar(carinho);


            // esse é o metodo que  dá o feedback se o teste foi feito com sucesso ou não 
            Assert.AreEqual("Fugão a carvão", algoritmo.Menor.Nome);
            Assert.AreEqual("lap-top", algoritmo.Maior.Nome);

            if (product_03 == algoritmo.Menor & product_01 == algoritmo.Maior)
            {
                Console.WriteLine("Teste maior e menor produto para produtos adicionados na carinha do forma crescente PASSOU !!!");
            }
            else
            {
                Console.WriteLine("Teste maior e menor produto para produtos adicionados na carinha do forma crescente NÃO PASSOU !!!");
            }

        }

        [Test]
        public void UnicoProduto()
        {
            Carinho_de_compra carinho = new Carinho_de_compra();
            carinho.Add_Product(product_01);

            MaiorMenor algoritmo = new MaiorMenor();
            algoritmo.Buscar(carinho);

            // esse é o metodo que  dá o feedback se o teste foi feito com sucesso ou não 
            Assert.AreEqual("Fugão a carvão", algoritmo.Menor.Nome);
            Assert.AreEqual("lap-top", algoritmo.Maior.Nome);

            //if (carinho.Products.FirstOrDefault().Equals(product_01))
            //{
            //    Console.WriteLine("Teste maior e menor produto para um produto na carinha PASSOU !!!");
            //}
            //else
            //{
            //    Console.WriteLine("Teste maior e menor produto para um produto na carinha NÂO PASSOU !!!");
            //}
        }

    }
}
