using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "uma string qualquer";
            dynamic d3 = System.DateTime.Today;
            dynamic d4 = new List<int>() { 123, 456, 789 };

            //As conversões entre objetos dinâmicos e outros tipos são fáceis. Isso permite que o desenvolvedor mude entre o comportamento dinâmico e o não dinâmico.

            //Qualquer objeto pode ser convertido no tipo dinâmico implicitamente, conforme mostrado nos exemplos a seguir.            


            //Por outro lado, uma conversão implícita pode ser aplicada dinamicamente a qualquer expressão do tipo dynamic.

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            IList<int> lista = d4;

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d4: {d4}");
        }
    }
}
