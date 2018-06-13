using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            //Conversões implícitas

            //Para tipos numéricos internos, uma conversão implícita poderá ser feita quando o
            //valor a ser armazenado puder se ajustar à variável sem ser truncado ou arredondado.

            //Por exemplo, uma variável do tipo long (inteiro de 8 bytes) pode armazenar
            //qualquer valor que uma int (4 bytes em um computador de 32 bits) pode armazenar.

            //No exemplo a seguir, o compilador converte implicitamente o valor à direita para 
            //um tipo long antes de atribuí-lo à grandeNumero.

            //// Conversão implícita. A variável long pode conter qualquer valor que um int suporta

            int num = 2147483647;
            long grandeNumero = num;
            Console.WriteLine($"grandeNumero: {grandeNumero}");
            //Resultado
            //grandeNumero: 2147483647


            //Tabela de conversões numéricas implícitas.

            //De Para
            //========
            //sbyte   short, int, long, float, double ou decimal
            //byte    short, ushort, int, uint, long, ulong, float, double ou decimal
            //short   int, long, float, double ou decimal
            //ushort  int, uint, long, ulong, float, double ou decimal
            //int long, float, double ou decimal
            //uint    long, ulong, float, double ou decimal
            //long    float, double ou decimal
            //char    ushort, int, uint, long, ulong, float, double ou decimal
            //float   double
            //ulong   float, double ou decimal

            //Para tipos de referência, uma conversão implícita sempre existe de uma classe para 
            //qualquer uma das suas interfaces ou classes base diretas ou indiretas.
            //Nenhuma sintaxe especial é necessária porque uma classe derivada sempre contém 
            //todos os membros de uma classe base.

            Gato gato = new Gato();
            Animal animal = gato; // Sempre funciona!  
            Console.WriteLine($"animal.GetType(): {animal.GetType()}");
            //Resultado
            //animal.GetType(): certificacao_csharp_roteiro.Gato
        }
    }
}
