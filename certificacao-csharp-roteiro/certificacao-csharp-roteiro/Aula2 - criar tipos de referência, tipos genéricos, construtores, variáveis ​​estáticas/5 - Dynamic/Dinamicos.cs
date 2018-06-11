using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            System.Console.WriteLine($"objeto.GetType(): {objeto.GetType()}");
            //objeto = objeto + 3;
            //Error CS0019  Operator '+' cannot be applied to operands of type 'object' and 'int'

            dynamic dinamico = 1;
            System.Console.WriteLine($"dinamico.GetType(): {dinamico.GetType()}");

            dinamico = dinamico + 3;
            System.Console.WriteLine($"dinamico = dinamico + 3;");
            Console.WriteLine($"dinamico: {dinamico}");
        }
    }
}
