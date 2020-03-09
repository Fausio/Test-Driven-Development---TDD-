using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Testando o codigo do maior e menor produto no carinho de copra
            //Banner.Tdd();
            //TestMaiorMenor teste = new TestMaiorMenor();

            //teste.OrdemDecrescente();
            //teste.OrdernCrescente();
            //teste.UnicoProduto();
            #endregion

            #region testando o codigo de numeros romanos 

            TesteConversorDeNumeroRomano teste = new TesteConversorDeNumeroRomano(); 
            teste.ConverterUmNumeroRomano();
            teste.ConverterMaisDeUmNumeroRomanoSemRegraDeMenorNumeroAEsquerda();
            teste.ConverterMaisDeUmNumeroRomanoComRegraDeMenorNumeroAEsquerda();
            #endregion

            Console.ReadKey();




        }
    }
}
