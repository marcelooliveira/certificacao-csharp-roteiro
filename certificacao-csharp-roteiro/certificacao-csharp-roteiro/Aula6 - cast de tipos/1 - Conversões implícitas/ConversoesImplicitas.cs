using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas
    {
        //Conversões implícitas
        //Para tipos numéricos internos, uma conversão implícita poderá ser feita quando o valor a ser armazenado puder se ajustar à variável sem ser truncado ou arredondado.Por exemplo, uma variável do tipo long (inteiro de 8 bytes) pode armazenar qualquer valor que uma int (4 bytes em um computador de 32 bits) pode armazenar.No exemplo a seguir, o compilador converte implicitamente o valor à direita para um tipo long antes de atribuí-lo à bigNum.

        //C#

        //Copiar
        //// Implicit conversion. num long can
        //// hold any value an int can hold, and more!
        //int num = 2147483647;
        //long bigNum = num;
        //Para obter uma lista completa de todas as conversões numéricas implícitas, consulte Tabela de conversões numéricas implícitas.

        //Para tipos de referência, uma conversão implícita sempre existe de uma classe para qualquer uma das suas interfaces ou classes base diretas ou indiretas.Nenhuma sintaxe especial é necessária porque uma classe derivada sempre contém todos os membros de uma classe base.



        //Copiar
        //Derived d = new Derived();
        //Base b = d; // Always OK.  
    }
}
