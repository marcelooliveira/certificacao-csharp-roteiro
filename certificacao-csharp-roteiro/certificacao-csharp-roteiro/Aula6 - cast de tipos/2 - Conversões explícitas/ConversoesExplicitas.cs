using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas
    {
        //Conversões explícitas
        //No entanto, se uma conversão não puder ser realizada sem o risco de perda de informações, o compilador exigirá que você execute uma conversão explícita, que é chamada de cast.Uma conversão é uma maneira de informar explicitamente ao compilador que você pretende fazer a conversão e que você está ciente de que poderá ocorrer perda de dados.Para executar uma conversão, especifique entre parênteses o tipo para o qual você está convertendo, na frente do valor ou da variável a ser convertida.O seguinte programa converte um double em um int. O programa não será compilado sem a conversão.


        //C#

        //Copiar
        //class Test
        //{
        //    static void Main()
        //    {
        //        double x = 1234.7;
        //        int a;
        //        // Cast double to int.
        //        a = (int)x;
        //        System.Console.WriteLine(a);
        //    }
        //}
        //// Output: 1234
        //Para obter uma lista de conversões numéricas explícitas que são permitidas, consulte Tabela de conversões numéricas explícitas.

        //Para tipos de referência, uma conversão explícita será necessária se você precisar converter de um tipo base para um tipo derivado:


        //C#

        //Copiar
        //// Create a new derived type.  
        //Giraffe g = new Giraffe();

        //// Implicit conversion to base type is safe.  
        //Animal a = g;

        //// Explicit conversion is required to cast back  
        //// to derived type. Note: This will compile but will  
        //// throw an exception at run time if the right-side  
        //// object is not in fact a Giraffe.  
        //Giraffe g2 = (Giraffe)a;
        //Uma operação de conversão entre tipos de referência não altera o tipo de tempo de execução do objeto subjacente.Ela apenas altera o tipo do valor que está sendo usado como uma referência a esse objeto.Para obter mais informações, consulte Polimorfismo.
    }
}
