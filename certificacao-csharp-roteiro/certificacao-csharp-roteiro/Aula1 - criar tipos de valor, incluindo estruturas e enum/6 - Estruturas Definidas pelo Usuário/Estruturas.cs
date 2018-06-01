using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula1___criar_tipos_de_valor__incluindo_estruturas_e_enum._6___Estruturas_Definidas_pelo_Usuário
{
    class Estruturas
    {
        //Usando structs(Guia de Programação em C#)
        //20/07/2015
        //5 minutos para ler
        //Colaboradores
        //dotnet bot  olprod OpenLocalizationService
        //O tipo struct é adequado para representar objetos leves como Point, Rectangle e Color.Embora seja conveniente representar um ponto como uma classe com Propriedades Auto-implementadas, um struct pode ser mais eficiente em alguns cenários.Por exemplo, se você declarar uma matriz de 1000 objetos Point, alocará memória adicional para referenciar cada objeto, nesse caso, um struct será mais barato.Como o.NET Framework contém um objeto chamado Point, o struct neste exemplo é chamado “CoOrds”.

        //C#

        //Copiar
        //public struct CoOrds
        //{
        //    public int x, y;

        //    public CoOrds(int p1, int p2)
        //    {
        //        x = p1;
        //        y = p2;
        //    }
        //}
        //É um erro ao definir um construtor(sem parâmetros) padrão para um struct. Também é um erro ao inicializar um campo de instância em um corpo de struct. Você pode inicializar membros de struct externamente acessíveis somente por meio de um construtor com parâmetros, do construtor padrão implícito, de um inicializador de objeto ou acessando os membros individualmente depois que o struct é declarado.Todos os membros particulares ou, de outro modo, inacessíveis exigem o uso de construtores exclusivamente.
        //Quando você cria um objeto de struct usando o operador new, ele é criado e o construtor apropriado é chamado de acordo com a assinatura do construtor.Diferentemente das classes, os structs podem ser instanciados sem usar o operador new. Nesse caso, não há nenhuma chamada do construtor, o que torna a alocação mais eficiente.No entanto, os campos permanecerão não atribuídos e o objeto não poderá ser usado até que todos os campos sejam inicializados.Isso inclui a incapacidade de obter ou definir valores por meio de propriedades autoimplementadas.
        //Se você criar uma instância de um objeto de struct usando o construtor sem parâmetros padrão, todos os membros serão atribuídos de acordo com seus valores padrão.
        //Ao escrever um construtor com parâmetros para um struct, é necessário inicializar explicitamente todos os membros; caso contrário, um ou mais membros permanecerão não atribuídos e o struct não poderá ser usado, produzindo o erro do compilador CS0171.

        //Não há nenhuma herança para structs como há para classes.Um struct não pode herdar de outra estrutura ou classe e ele não pode ser a base de uma classe.No entanto, os structs herdam da classe base Object.Um struct pode implementar interfaces e ele faz isso exatamente como as classes.

        //Você não pode declarar uma classe usando a palavra-chave struct. No C#, as classes e os structs são semanticamente diferentes. Um struct é um tipo de valor, enquanto uma classe é um tipo de referência. Para obter mais informações, consulte Value Types (Tipos de Valor).

        //A menos que você precise de semântica de tipo de referência, uma pequena classe pode ser tratada com mais eficiência pelo sistema se você declará-la como um struct em vez disso.

        //Exemplo 1
        //Descrição
        //Este exemplo demonstra a inicialização de struct usando construtores parametrizados e padrão.

        //Código
        //C#

        //Copiar
        //public struct CoOrds
        //{
        //    public int x, y;

        //    public CoOrds(int p1, int p2)
        //    {
        //        x = p1;
        //        y = p2;
        //    }
        //}
        //C#

        //Copiar
        //// Declare and initialize struct objects.
        //class TestCoOrds
        //{
        //    static void Main()
        //    {
        //        // Initialize:   
        //        CoOrds coords1 = new CoOrds();
        //        CoOrds coords2 = new CoOrds(10, 10);

        //        // Display results:
        //        Console.Write("CoOrds 1: ");
        //        Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

        //        Console.Write("CoOrds 2: ");
        //        Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);

        //        // Keep the console window open in debug mode.
        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //}
        ///* Output:
        //    CoOrds 1: x = 0, y = 0
        //    CoOrds 2: x = 10, y = 10
        //*/
        //Exemplo 2
        //Descrição
        //Este exemplo demonstra um recurso que é exclusivo para struct. Ele cria um objeto CoOrds sem usar o operador new. Se você substituir a palavra struct pela palavra class, o programa não compilará.

        //Código
        //C#

        //Copiar
        //public struct CoOrds
        //{
        //    public int x, y;

        //    public CoOrds(int p1, int p2)
        //    {
        //        x = p1;
        //        y = p2;
        //    }
        //}
        //C#

        //Copiar
        //// Declare a struct object without "new."
        //class TestCoOrdsNoNew
        //{
        //    static void Main()
        //    {
        //        // Declare an object:
        //        CoOrds coords1;

        //        // Initialize:
        //        coords1.x = 10;
        //        coords1.y = 20;

        //        // Display results:
        //        Console.Write("CoOrds 1: ");
        //        Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

        //        // Keep the console window open in debug mode.
        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //}
        //// Output: CoOrds 1: x = 10, y = 20
    }
}
