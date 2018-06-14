using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Parse : IAulaItem
    {
        public void Executar()
        {
            string[] valores =
                {
                    "+13230",
                    "-0",
                    "1,390,146",
                    "$190,235,421,127",
                    "0xFA1B",
                    "163042",
                    "-10",
                    "007",
                    "2147483647",
                    "2147483648",
                    "16e07",
                    "134985.0",
                    "-12034",
                    "-2147483648",
                    "-2147483649"
                };

            foreach (string valor in valores)
            {
                try
                {
                    int numero = Int32.Parse(valor);
                    Console.WriteLine("{0} --> {1}", valor, numero);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Formato inválido", valor);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0}: Overflow", valor);
                }
            }
        }
    }
}
