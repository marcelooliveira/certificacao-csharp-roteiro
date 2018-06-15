using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ResolucaoSobrecarga : IAulaItem
    {
        public void Executar()
        {
            AppCalculadora calculadora = new AppCalculadora();


            // A linha seguinte é válida.
            calculadora.Somar(123);
            Console.WriteLine($"calculadora.Valor: {calculadora.Valor}");

            dynamic stringDinamica = "uma string";
            // A seguinte instrução NÃO CAUSA erro de compilação, mesmo calculadora não sendo
            // dinâmica. Mas ocorre umma exceção de tempo de execução porque o tipo de tempo de
            // execução é string.
            //calculadora.Subtrair(stringDinamica);
            //Console.WriteLine($"calculadora.Valor: {calculadora.Valor}");

            // A seguinte instrução CAUSA erro de compilação.
            //calculadora.Subtrair("xpto");
        }
    }
}
