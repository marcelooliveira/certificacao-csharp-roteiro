using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Delegates
    {
        //delegate (Referência de C#)
        //20/07/2015
        //2 minutos para ler
        //Colaboradores
        //dotnet bot  olprod OpenLocalizationService
        //A declaração de um tipo de delegado é semelhante a uma assinatura de método. Ela tem um valor retornado e parâmetros de qualquer tipo:

        //C#

        //Copiar
        //public delegate void TestDelegate(string message);
        //public delegate int TestDelegate(MyType m, long num);
        //Um delegate é um tipo de referência que pode ser usado para encapsular um método nomeado ou anônimo. Representantes são semelhantes a ponteiros de função em C++. No entanto, os representantes são fortemente tipados e seguros.Para aplicativos de representantes, consulte Representantes e Representantes genéricos.

        //Comentários
        //Os representantes são a base dos Eventos.


        //Um delegado pode ser instanciado associando-o a um método nomeado ou anônimo.Para obter mais informações, consulte Métodos anônimos e Métodos nomeados.


        //O delegado deve ser instanciado com um método ou expressão lambda que tenha um tipo de retorno compatível e parâmetros de entrada. Para obter mais informações sobre o grau de variação permitido na assinatura do método, consulte Variação em representantes. Para uso com métodos anônimos, o delegado e o código a ser associado a ele são declarados juntos.As duas formas de instanciar representantes são discutidas nesta seção.


        //Exemplo
        //C#

        //Copiar
        //// Declare delegate -- defines required signature:
        //delegate double MathAction(double num);

        //class DelegateTest
        //{
        //    // Regular method that matches signature:
        //    static double Double(double input)
        //    {
        //        return input * 2;
        //    }

        //    static void Main()
        //    {
        //        // Instantiate delegate with named method:
        //        MathAction ma = Double;

        //        // Invoke delegate ma:
        //        double multByTwo = ma(4.5);
        //        Console.WriteLine("multByTwo: {0}", multByTwo);

        //        // Instantiate delegate with anonymous method:
        //        MathAction ma2 = delegate (double input)
        //        {
        //            return input * input;
        //        };

        //        double square = ma2(5);
        //        Console.WriteLine("square: {0}", square);

        //        // Instantiate delegate with lambda expression
        //        MathAction ma3 = s => s * s * s;
        //        double cube = ma3(4.375);

        //        Console.WriteLine("cube: {0}", cube);
        //    }
        //    // Output:
        //    // multByTwo: 9
        //    // square: 25
        //    // cube: 83.740234375
        //}
        //Especificação da Linguagem C#
        //Para obter mais informações, consulte a Especificação da linguagem C#. A especificação da linguagem é a fonte definitiva para a sintaxe e o uso de C#.
    }
}
