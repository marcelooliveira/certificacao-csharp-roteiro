using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes
    {
        //enum (Referência de C#)
        //20/07/2015
        //7 minutos para ler
        //Colaboradores
        //dotnet bot  olprod OpenLocalizationService
        //A palavra-chave enum é usada para declarar uma enumeração, um tipo distinto que consiste em um conjunto de constantes nomeadas denominado lista de enumeradores.

        //Normalmente, é melhor definir um enum diretamente dentro de um namespace para que todas as classes no namespace possam acessá-lo com a mesma conveniência.No entanto, um enum também pode ser aninhado dentro de uma classe ou struct.

        //Por padrão, o primeiro enumerador tem o valor 0 e o valor de cada enumerador seguinte é aumentado em 1. Por exemplo, na seguinte enumeração, Sat é 0, Sun é 1, Mon é 2 e assim por diante.

        //C#

        //Copiar
        //enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        //Enumeradores podem usar inicializadores para substituir os valores padrão, conforme mostrado no exemplo a seguir.

        //C#

        //Copiar
        //enum Day { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        //Nesta enumeração, a sequência de elementos é forçada a iniciar a partir de 1 em vez de 0. No entanto, incluir uma constante que tenha o valor de 0 é recomendado.Para obter mais informações, consulte Tipos de enumeração.


        //Cada tipo de enumeração tem um tipo subjacente, que pode ser qualquer tipo integral exceto por char. O tipo subjacente padrão dos elementos de enumeração é int. Para declarar um enum de outro tipo integral, como bytes, use uma vírgula após o identificador seguida pelo tipo, conforme mostrado no exemplo a seguir.

        //C#

        //Copiar
        //enum Day : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        //Os tipos aprovados para um enum são byte, sbyte, short, ushort, int, uint, long ou ulong.

        //Qualquer valor no intervalo do tipo subjacente pode ser atribuído a uma variável do tipo Day; os valores não são limitados às constantes nomeadas.

        //O valor padrão de um enum E é o valor produzido pela expressão(E)0.

        //Observação

        //Um enumerador não pode conter espaços em branco em seu nome.

        //O tipo subjacente especifica quanto armazenamento é alocado para cada enumerador. No entanto, uma conversão explícita é necessária para converter de um tipo enum em um tipo integral.Por exemplo, a instrução a seguir atribui o enumerador Sun a uma variável do tipo int usando uma conversão para converter de enum em int.

        //C#

        //Copiar
        //int x = (int)Day.Sun;
        //Quando você aplica System.FlagsAttribute a uma enumeração que contém elementos que podem ser combinados com uma operação OR bit a bit, o atributo afeta o comportamento do enum quando ele é usado com algumas ferramentas.Você pode observar essas alterações quando usa ferramentas como os métodos da classe Console e o Avaliador de Expressão. (Consulte o terceiro exemplo.)

        //Programação robusta
        //Assim como ocorre com qualquer constante, todas as referências aos valores individuais de um enum são convertidas em literais numéricos em tempo de compilação.Isso pode criar problemas de controle de versão, conforme descrito em Constantes.

        //Atribuir valores adicionais a novas versões de enums ou alterar os valores dos membros de enum em uma nova versão pode causar problemas para códigos-fonte dependentes.Valores de enum frequentemente são usados em instruções switch. Se elementos adicionais tiverem sido adicionados ao tipo enum, a seção padrão da instrução switch pode ser selecionada inesperadamente.

        //Se outros desenvolvedores usarem seu código, você deverá fornecer diretrizes sobre como seu código deve reagir se novos elementos forem adicionados a qualquer tipo enum.

        //Exemplo
        //No exemplo a seguir, uma enumeração, Day, é declarada.Dois enumeradores são convertidos explicitamente em inteiros e atribuídos a variáveis de inteiro.

        //C#

        //Copiar

        //public class EnumTest
        //{
        //enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        //static void Main()
        //{
        //    int x = (int)Day.Sun;
        //    int y = (int)Day.Fri;
        //    Console.WriteLine("Sun = {0}", x);
        //    Console.WriteLine("Fri = {0}", y);
        //}
        //}
        ///* Output:
        //Sun = 0
        //Fri = 5
        //*/
        //Exemplo
        //No exemplo a seguir, a opção de tipo base é usada para declarar uma enum cujos membros são do tipo long. Observe que, mesmo que o tipo subjacente da enumeração seja long, os membros da enumeração ainda devem ser convertidos explicitamente no tipo long usando uma conversão.

        //C#

        //Copiar
        //public class EnumTest2
        //{
        //enum Range : long { Max = 2147483648L, Min = 255L };
        //static void Main()
        //{
        //    long x = (long)Range.Max;
        //    long y = (long)Range.Min;
        //    Console.WriteLine("Max = {0}", x);
        //    Console.WriteLine("Min = {0}", y);
        //}
        //}
        ///* Output:
        //Max = 2147483648
        //Min = 255
        //*/
        //Exemplo
        //O exemplo de código a seguir ilustra o uso e o efeito do atributo System.FlagsAttribute em uma declaração enum.

        //C#

        //Copiar
        //// Add the attribute Flags or FlagsAttribute.
        //[Flags]
        //public enum CarOptions
        //{
        //// The flag for SunRoof is 0001.
        //SunRoof = 0x01,
        //// The flag for Spoiler is 0010.
        //Spoiler = 0x02,
        //// The flag for FogLights is 0100.
        //FogLights = 0x04,
        //// The flag for TintedWindows is 1000.
        //TintedWindows = 0x08,
        //}

        //class FlagTest
        //{
        //static void Main()
        //{
        //    // The bitwise OR of 0001 and 0100 is 0101.
        //    CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;

        //    // Because the Flags attribute is specified, Console.WriteLine displays
        //    // the name of each enum element that corresponds to a flag that has
        //    // the value 1 in variable options.
        //    Console.WriteLine(options);
        //    // The integer value of 0101 is 5.
        //    Console.WriteLine((int)options);
        //}
        //}
        ///* Output:
        //SunRoof, FogLights
        //5
        //*/
        //Comentários
        //Se você remover Flags, o exemplo exibirá os seguintes valores:

        //5

        //5

        //Especificação da Linguagem C#
        //Para obter mais informações, consulte a Especificação da linguagem C#. A especificação da linguagem é a fonte definitiva para a sintaxe e o uso de C#.
    }
}
