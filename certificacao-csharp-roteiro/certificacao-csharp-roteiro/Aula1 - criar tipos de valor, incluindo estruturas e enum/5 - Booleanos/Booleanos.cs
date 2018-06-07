using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1;
            //Error CS0029  Cannot implicitly convert type 'int' to 'bool'

            bool possuiSaldo = true;

            // WriteLine() automaticamente converte o valor de "possuiSaldo" para texto.
            Console.WriteLine(possuiSaldo);

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");

            // Atribui a diasPar o valor de uma expressão booleana.
            bool diasPar = (dias % 2 == 0);

            // Executa um braço da condição, dependendo se diasPar for verdadeiro ou falso
            //if (diasPar == true)
            if (diasPar)
                {
                Console.WriteLine("dias é um número par");
            }
            else
            {
                Console.WriteLine("dias é um número ímpar");
            }
        }
}
}
