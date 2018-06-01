using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing
    {
        //Unboxing
        //A conversão unboxing é uma conversão explícita do tipo object para um tipo de valor ou de um tipo de interface para um tipo de valor que implementa a interface. Uma operação de conversão unboxing consiste em:

        //Verificar a instância do objeto para garantir que ele é um valor da conversão boxing de um determinado tipo de valor.

        //Copiar o valor da instância para a variável de tipo de valor.

        //As instruções a seguir demonstram operações conversão boxing e unboxing:

        //C#

        //Copiar
        //int i = 123;      // a value type
        //object o = i;     // boxing
        //int j = (int)o;   // unboxing
        //A figura a seguir demonstra o resultado das instruções anteriores.

        //Gráfico de Conversão UnBoxing
        //Conversão unboxing

        //Para a conversão unboxing de tipos de valor ter êxito em tempo de execução, o item sendo submetido à conversão unboxing deve ser uma referência para um objeto que foi criado anteriormente ao realizar a conversão boxing de uma instância desse tipo de valor. Tentar realizar a conversão unboxing de null causa uma NullReferenceException.Tentar realizar a conversão unboxing de uma referência para um tipo de valor incompatível causa uma InvalidCastException.

        //Exemplo
        //O exemplo a seguir demonstra um caso de conversão unboxing inválida e o InvalidCastException resultante. Usando try e catch, uma mensagem de erro é exibida quando o erro ocorre.

        //C#

        //Copiar
        //class TestUnboxing
        //{
        //static void Main()
        //{
        //int i = 123;
        //object o = i;  // implicit boxing

        //try
        //{
        //    int j = (short)o;  // attempt to unbox

        //    System.Console.WriteLine("Unboxing OK.");
        //}
        //catch (System.InvalidCastException e)
        //{
        //    System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
        //}
        //}
        //}
        //Este programa produz:

        //Specified cast is not valid.Error: Incorrect unboxing.

        //Se você alterar a instrução:


        //Copiar
        //int j = (short)o;
        //para:


        //Copiar
        //int j = (int)o;
        //a conversão será executada e você receberá a saída:

        //Unboxing OK.

        //Especificação da Linguagem C#
        //Para obter mais informações, consulte a Especificação da linguagem C#. A especificação da linguagem é a fonte definitiva para a sintaxe e o uso de C#.

        //Seções relacionadas
        //Para saber mais:

        //Tipos de referência

        //Tipos de valor
    }
}
