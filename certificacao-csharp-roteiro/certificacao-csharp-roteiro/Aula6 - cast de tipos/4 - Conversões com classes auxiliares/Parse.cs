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
            string textoDigitado = "123";

            //int numeroConvertido = "123";

            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine($"numeroConvertido: {numeroConvertido}");

            //textoDigitado = "abc";
            //numeroConvertido = int.Parse(textoDigitado);
            //Console.WriteLine($"numeroConvertido: {numeroConvertido}");
            
            textoDigitado = "abc";
            int.TryParse(textoDigitado, out numeroConvertido);
            Console.WriteLine($"numeroConvertido: {numeroConvertido}");

            if (int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine($"numeroConvertido: {numeroConvertido}");
            }
            else
            {
                Console.WriteLine($"Texto '{textoDigitado}' não pode ser convertido para int");
            }

            //textoDigitado = "123,45";
            //if (decimal.TryParse(textoDigitado, out decimal valorConvertido))
            //{
            //    Console.WriteLine($"valorConvertido: {valorConvertido}");
            //}
            //else
            //{
            //    Console.WriteLine($"Texto '{textoDigitado}' não pode ser convertido para decimal");
            //}

            //textoDigitado = "R$ 123,45";
            //if (decimal.TryParse(textoDigitado, out decimal valorConvertido))
            //{
            //    Console.WriteLine($"valorConvertido: {valorConvertido}");
            //}
            //else
            //{
            //    Console.WriteLine($"Texto '{textoDigitado}' não pode ser convertido para decimal");
            //}
            ////Texto 'R$ 123,45' não pode ser convertido para decimal


            textoDigitado = "R$ 123,45";
            if (decimal.TryParse(textoDigitado, System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal valorConvertido))
            {
                Console.WriteLine($"valorConvertido: {valorConvertido}");
            }
            else
            {
                Console.WriteLine($"Texto '{textoDigitado}' não pode ser convertido para decimal");
            }
            //Texto 'R$ 123,45' não pode ser convertido para decimal

        }
    }
}
