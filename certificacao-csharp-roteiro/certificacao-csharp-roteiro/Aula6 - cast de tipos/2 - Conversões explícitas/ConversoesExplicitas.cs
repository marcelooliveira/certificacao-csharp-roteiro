using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            //No entanto, se uma conversão não puder ser realizada sem o risco de perda de informações, o compilador exigirá que você execute uma conversão explícita, que é chamada de cast.Uma conversão é uma maneira de informar explicitamente ao compilador que você pretende fazer a conversão e que você está ciente de que poderá ocorrer perda de dados.Para executar uma conversão, especifique entre parênteses o tipo para o qual você está convertendo, na frente do valor ou da variável a ser convertida.O seguinte programa converte um double em um int. O programa não será compilado sem a conversão.

            double x = 1234.7;
            int a;
            // "Molda" (converte) um double como int.
            a = (int)x;
            System.Console.WriteLine(a);

            //// Output: 1234
            //Para obter uma lista de conversões numéricas explícitas que são permitidas, consulte Tabela de conversões numéricas explícitas.

            //Para tipos de referência, uma conversão explícita será necessária se você precisar converter de um tipo base para um tipo derivado:

            // Cria um novo tipo derivado
            Gato gato = new Gato();

            // Uma conversão implícita para o tipo base é seguro
            Animal animal = gato;
            Console.WriteLine($"animal.GetType(): {animal.GetType()}");
            //animal.GetType(): certificacao_csharp_roteiro.Gato

            // Conversão explícita é obrigatória para converter de volta
            // para o tipo derivado.
            Gato gato2 = (Gato)animal;
            Console.WriteLine($"gato2.GetType(): {gato2.GetType()}");
            //gato2.GetType(): certificacao_csharp_roteiro.Gato
            // Uma operação de conversão entre tipos de referência não altera o tipo de tempo de execução do objeto subjacente.

            // Ela apenas altera o tipo do valor que está sendo usado como uma referência a esse objeto.
        }
    }
}
