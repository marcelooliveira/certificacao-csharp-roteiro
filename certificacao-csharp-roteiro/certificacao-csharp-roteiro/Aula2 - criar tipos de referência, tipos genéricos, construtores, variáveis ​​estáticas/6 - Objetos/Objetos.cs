using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos
    {
        //object (Referência de C#)
        //20/07/2015
        //2 minutos para ler
        //Colaboradores
        //Bill Wagner  olprod OpenLocalizationService
        //O tipo object é um alias para Object no.NET Framework.No sistema de tipos unificado do C#, todos os tipos, predefinidos e definidos pelo usuário, tipos de referência e tipos de valor, herdam direta ou indiretamente de Object. Você pode atribuir valores de qualquer tipo a variáveis do tipo object. Quando uma variável de um tipo de valor é convertida para um objeto, ela é chamada de boxed. Quando uma variável do objeto do tipo é convertida para um tipo de valor, ela é chamada de unboxed. Para obter mais informações, consulte Boxing e unboxing.

        //Exemplo
        //O exemplo a seguir mostra como variáveis do tipo object podem aceitar valores de qualquer tipo de dados e como as variáveis do tipo object pode usar métodos Object do .NET Framework.

        //C#

        //Copiar
        //class ObjectTest
        //{
        //    public int i = 10;
        //}

        //class MainClass2
        //{
        //    static void Main()
        //    {
        //        object a;
        //        a = 1;   // an example of boxing
        //        Console.WriteLine(a);
        //        Console.WriteLine(a.GetType());
        //        Console.WriteLine(a.ToString());

        //        a = new ObjectTest();
        //        ObjectTest classRef;
        //        classRef = (ObjectTest)a;
        //        Console.WriteLine(classRef.i);
        //    }
        //}
        ///* Output
        //    1
        //    System.Int32
        //    1
        //    * 10
        //*/
        //Especificação da Linguagem C#
        //Para obter mais informações, consulte a Especificação da linguagem C#. A especificação da linguagem é a fonte definitiva para a sintaxe e o uso de C#.
    }
}
