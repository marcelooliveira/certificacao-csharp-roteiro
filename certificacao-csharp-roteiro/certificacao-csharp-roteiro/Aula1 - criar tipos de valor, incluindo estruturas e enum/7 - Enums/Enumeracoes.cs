using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        //Quando você aplica System.FlagsAttribute a uma enumeração que contém elementos que podem 
        //ser combinados com uma operação OR bit a bit, o atributo afeta o comportamento do enum quando
        //ele é usado com algumas ferramentas.Você pode observar essas alterações quando usa
        //    ferramentas como os métodos da classe Console e o Avaliador de Expressão. (Consulte o 
        //    terceiro exemplo.)

        //Programação robusta
        //Assim como ocorre com qualquer constante, todas as referências aos valores individuais de 
        //um enum são convertidas em literais numéricos em tempo de compilação.Isso pode criar 
        //    problemas de controle de versão, conforme descrito em Constantes.

        //Atribuir valores adicionais a novas versões de enums ou alterar os valores dos membros de
        //enum em uma nova versão pode causar problemas para códigos-fonte dependentes.Valores de enum 
        //frequentemente são usados em instruções switch. Se elementos adicionais tiverem sido 
        //adicionados ao tipo enum, a seção padrão da instrução switch pode ser selecionada 
        //inesperadamente.

        //Se outros desenvolvedores usarem seu código, você deverá fornecer diretrizes sobre como 
        //seu código deve reagir se novos elementos forem adicionados a qualquer tipo enum.

        //Exemplo
        //No exemplo a seguir, uma enumeração, Day, é declarada.Dois enumeradores são convertidos
        //explicitamente em inteiros e atribuídos a variáveis de inteiro.

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
        public void Executar()
        {
            DiaDaSemana segunda = DiaDaSemana.Seg;

            DiaDaSemana primeiroDia = DiaDaSemana.Seg;
            Console.WriteLine($"primeiroDia: {primeiroDia}");

            Console.WriteLine($"(primeiroDia == 0): {(primeiroDia == 0)}");

            Console.WriteLine($"(int)DiaDaSemanaInicio3.Seg = {(int)DiaDaSemanaInicio3.Seg}");

            PlanoTVAssinatura residencia1 = PlanoTVAssinatura.TV | PlanoTVAssinatura.Celular;
            PlanoTVAssinatura residencia2 = PlanoTVAssinatura.Celular | PlanoTVAssinatura.Internet;
            PlanoTVAssinatura residencia3 = PlanoTVAssinatura.FoneFixo | PlanoTVAssinatura.Celular;

            Console.WriteLine($"residencia1 tem internet?" +
                $"{(residencia1 & PlanoTVAssinatura.Internet) == PlanoTVAssinatura.Internet}");
            Console.WriteLine($"residencia2 tem internet? " +
                $"{(residencia2 & PlanoTVAssinatura.Internet) == PlanoTVAssinatura.Internet}");
            Console.WriteLine($"residencia3 tem internet? " +
                $"{(residencia3 & PlanoTVAssinatura.Internet) == PlanoTVAssinatura.Internet}");
        }
    }

    enum DiaDaSemana { Seg, Ter, Qua, Qui, Sex, Sab, Dom };

    enum DiaDaSemanaInicio3 { Seg = 3, Ter, Qua, Qui, Sex, Sab, Dom };

    enum DiaTipado : long { Seg = 0, Ter, Qua, Qui, Sex, Sab, Dom };

    [FlagsAttribute]
    public enum PlanoTVAssinatura
    {
        Nenhum = 0,
        TV = 1,
        FoneFixo = 2,
        Celular = 4,
        Internet = 8,
        Ilimitado = 16
    }
}
