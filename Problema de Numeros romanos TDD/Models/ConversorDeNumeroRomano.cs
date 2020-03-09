using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Problema_de_Numeros_romanos_TDD.Models
{
    public class ConversorDeNumeroRomano
    {
        public int Acomulador = 0;
        public int UltimoVizinhoADireita = 0;
        public string caracterInvalidoString;

        public Dictionary<string, int> TabelaDeNumerosRomanos = new Dictionary<string, int>()
        {
             {"I",1},
             {"V",5},
             {"X",10},
             {"L",50 },
             {"C",100},
             {"D",500 },
             {"M",1000 }
        };

        public void Converter(string NumeroRomano)
        {
            

                if (NumeroRomano.Length == 0)
                {
                    Acomulador = TabelaDeNumerosRomanos[NumeroRomano];
                }
                if (NumeroRomano.Length > 0)
                {
                    for (int i = NumeroRomano.Length - 1; i >= 0; i--)
                    {
                        //pega o inteiro recerente ao simbolo atual 
                        int atual = TabelaDeNumerosRomanos[NumeroRomano[i].ToString()];

                        //se o da direita for menor , o multiplicaremos por -1 para torná-lo negativo
                        int multiplicador = 1;
                        if (atual < UltimoVizinhoADireita)
                        {
                            multiplicador = -1;
                        }

                        Acomulador += TabelaDeNumerosRomanos[NumeroRomano[i].ToString()] * multiplicador;


                        // atualiza o vizinho da direita
                        UltimoVizinhoADireita = atual;


                    }
                }
            }
        }
    }
 