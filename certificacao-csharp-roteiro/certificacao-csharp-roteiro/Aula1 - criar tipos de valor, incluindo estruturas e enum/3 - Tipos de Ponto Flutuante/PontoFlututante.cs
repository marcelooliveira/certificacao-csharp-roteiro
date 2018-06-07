using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PontoFlututante : IAulaItem
    {
        //Type      Approximate range        Precision
        //===============================================
        //float	    ±1.5e−45 to ±3.4e38	7    digits
        //double	±5.0e−324 to ±1.7e308	 15-16 digits

        public PontoFlututante()
        {
        }

        public void Executar()
        {
            double massaDaTerra = 5.9736e24; // System.Double
            float numeroPI = 3.14159f; // System.Single

            Console.WriteLine($"massaDaTerra: {massaDaTerra}");
            Console.WriteLine($"numeroPI: {numeroPI}");

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            float y = 4.5f;
            short z = 5;
            var resultado = x * y / z;
            Console.WriteLine("O resultado é {0}", resultado);
            Type type = resultado.GetType();
            Console.WriteLine("O resultado é do tipo: {0}", type.ToString());
        }
    }
}
