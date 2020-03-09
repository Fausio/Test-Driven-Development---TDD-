using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema_de_Numeros_romanos_TDD.Models;
    
namespace NUnit
{
    [TestFixture]
    class TesteConversorDeNumeroRomano
    {
        [Test]
        public void ConverterUmNumeroRomano()
        {

            ConversorDeNumeroRomano conversor = new ConversorDeNumeroRomano();

            conversor.Converter("X");

            //if (10 == conversor.Acomulador)
            //{
            //    Console.WriteLine("Teste Converter Um unico numero romano passou");
            //}                                                      
            //else                                                   
            //{                                                      
            //    Console.WriteLine("Teste Converter Um unico numero romano não passou");
            //}
            Assert.AreEqual(10, conversor.Acomulador);
        }

        
        [Test]
        public void ConverterMaisDeUmNumeroRomanoSemRegraDeMenorNumeroAEsquerda()
        {
            ConversorDeNumeroRomano conversor = new ConversorDeNumeroRomano();

            conversor.Converter("XXI");

            //if (21 == conversor.Acomulador)
            //{
            //    Console.WriteLine("Teste Converter numeros romanos ordernados de forma crescente da esquerda para a direita passou com sucesso");
            //}
            //else
            //{
            //    Console.WriteLine("Teste Converter numeros romanos ordernados de forma crescente da esquerda para a direita não passou");
            //}
            Assert.AreEqual(21, conversor.Acomulador);

        }

        [Test]
        public void ConverterMaisDeUmNumeroRomanoComRegraDeMenorNumeroAEsquerda()
        {
            ConversorDeNumeroRomano conversor = new ConversorDeNumeroRomano();

            conversor.Converter("XIX");

            //if (19 == conversor.Acomulador)
            //{
            //    Console.WriteLine("Teste Converter numeros romanos  com regra de menor numero a esquerda passou com sucesso !!! ");
            //}
            //else
            //{
            //    Console.WriteLine("Teste Converter numeros romanos  com regra de menor numero a esquerda Não passou ");
            //}
            Assert.AreEqual(19, conversor.Acomulador);
        }

   
    }
}
