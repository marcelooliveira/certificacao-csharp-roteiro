using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosDeExtensao
    {
        //Os métodos de extensão permitem que você "adicione" tipos existentes sem criar um novo tipo derivado, recompilar ou, caso contrário, modificar o tipo original.Os métodos de extensão são um tipo especial de método estático, mas são chamados como se fossem métodos de instância no tipo estendido.No caso do código cliente gravado em C#, F# e Visual Basic, não há nenhuma diferença aparente entre chamar um método de extensão e os métodos realmente definidos em um tipo.

        //Os métodos de extensão mais comuns são os operadores de consulta padrão LINQ que adicionam funcionalidade de consulta aos tipos System.Collections.IEnumerable e System.Collections.Generic.IEnumerable<T> existentes. Para usar os operadores de consulta padrão, traga-os primeiro ao escopo com uma diretiva using System.Linq. Em seguida, qualquer tipo que implemente IEnumerable<T> parece ter métodos de instância como GroupBy, OrderBy, Average e assim por diante.Você pode exibir esses métodos adicionais no preenchimento de declaração do IntelliSense ao digitar "ponto" após uma instância de um tipo IEnumerable<T> como List<T> ou Array.

        //O exemplo a seguir mostra como chamar o método de consulta padrão OrderBy em qualquer matriz de inteiros. A expressão entre parênteses é uma expressão lambda. Vários operadores de consulta padrão obtêm expressões lambda como parâmetros, mas isso não é um requisito para métodos de extensão. Para obter mais informações, consulte Expressões Lambda.

        //C#

        //Copiar
        //class ExtensionMethods2
        //{

        //static void Main()
        //{
        //    int[] ints = { 10, 45, 15, 39, 21, 26 };
        //    var result = ints.OrderBy(g => g);
        //    foreach (var i in result)
        //    {
        //        System.Console.Write(i + " ");
        //    }
        //}
        //}
        ////Output: 10 15 21 26 39 45
        //Os métodos de extensão são definidos como estáticos, mas são chamados usando a sintaxe do método de instância.Seu primeiro parâmetro especifica em que tipo o método opera e o parâmetro é precedido pelo modificador this. Os métodos de extensão só estarão no escopo quando você importar explicitamente o namespace para seu código-fonte com uma diretiva using.

        //O exemplo a seguir mostra um método de extensão definido para a classe System.String.Observe que isso é definido em uma classe estática não aninhada e não genérica:

        //C#

        //Copiar
        //namespace ExtensionMethods
        //{
        //public static class MyExtensions
        //{
        //    public static int WordCount(this String str)
        //    {
        //        return str.Split(new char[] { ' ', '.', '?' },
        //                            StringSplitOptions.RemoveEmptyEntries).Length;
        //    }
        //}
        //}
        //O método de extensão WordCount pode ser colocado no escopo com esta diretiva using:

        //C#

        //Copiar
        //using ExtensionMethods;  
        //E pode ser chamado a partir de um aplicativo usando esta sintaxe:

        //C#

        //Copiar
        //string s = "Hello Extension Methods";
        //int i = s.WordCount();
        //Em seu código, você chama o método de extensão com sintaxe de método de instância.No entanto, a linguagem intermediária (IL) gerada pelo compilador converte seu código em uma chamada no método estático.Portanto, o princípio de encapsulamento ainda não está realmente sendo violado. De fato, os métodos de extensão não podem acessar variáveis particulares no tipo que estão estendendo.


        //Para obter mais informações, consulte Como implementar e chamar um método de extensão personalizado.


        //Em geral, provavelmente você chamará métodos de extensão com muito mais frequência do que implementará os seus próprios.Como os métodos de extensão são chamados com a sintaxe do método de instância, nenhum conhecimento especial é necessário para usá-los no código do cliente.Para habilitar métodos de extensão para um tipo específico, apenas adicione uma diretiva using para o namespace no qual os métodos estão definidos.Por exemplo, para usar os operadores de consulta padrão, adicione esta diretiva using ao seu código:

        //C#

        //Copiar
        //using System.Linq;  
        //(Também pode ser necessário adicionar uma referência a System.Core.dll.) Você observará que os operadores de consulta padrão agora são exibidos no IntelliSense como métodos adicionais disponíveis para a maioria dos tipos IEnumerable<T>.

        //Observação

        //Embora os operadores de consulta padrão não sejam exibidos no IntelliSense para String, eles ainda estarão disponíveis.

        //Associando Métodos de Extensão no Momento da Compilação
        //Você pode usar métodos de extensão para estender uma classe ou interface, mas não os substituir.Um método de extensão com o mesmo nome e assinatura que um método de interface ou classe nunca será chamado.No tempo de compilação, os métodos de extensão sempre têm menos prioridade que os métodos de instância definidos no próprio tipo.Em outras palavras, se um tipo possuir um método chamado Process(int i) e se você tiver um método de extensão com a mesma assinatura, o compilador sempre se associará ao método de instância.Quando o compilador encontra uma invocação de método, primeiro ele procura uma correspondência nos métodos de instância do tipo.Se nenhuma correspondência for encontrada, ele irá procurar todos os métodos de extensão definidos para o tipo e associará o primeiro método de extensão que encontrar.O exemplo a seguir demonstra como o compilador determina a qual método de extensão ou método de instância associar.

        //Exemplo
        //O exemplo a seguir demonstra as regras que o compilador C# segue ao determinar se deve associar uma chamada de método a um método de instância no tipo ou a um método de extensão. A classe estática Extensions contém métodos de extensão definidos para qualquer tipo que implementa IMyInterface. As classes A, B e C implementam a interface.

        //O método de extensão MethodB nunca é chamado porque seu nome e assinatura são exatamente iguais aos métodos já implementados pelas classes.

        //Quando o compilador não consegue localizar um método de instância com uma assinatura compatível, ele se associa a um método de extensão correspondente se houver.

        //C#

        //Copiar
        //// Define an interface named IMyInterface.
        //namespace DefineIMyInterface
        //{
        //using System;

        //public interface IMyInterface
        //{
        //    // Any class that implements IMyInterface must define a method
        //    // that matches the following signature.
        //    void MethodB();
        //}
        //}


        //// Define extension methods for IMyInterface.
        //namespace Extensions
        //{
        //using System;
        //using DefineIMyInterface;

        //// The following extension methods can be accessed by instances of any 
        //// class that implements IMyInterface.
        //public static class Extension
        //{
        //    public static void MethodA(this IMyInterface myInterface, int i)
        //    {
        //        Console.WriteLine
        //            ("Extension.MethodA(this IMyInterface myInterface, int i)");
        //    }

        //    public static void MethodA(this IMyInterface myInterface, string s)
        //    {
        //        Console.WriteLine
        //            ("Extension.MethodA(this IMyInterface myInterface, string s)");
        //    }

        //    // This method is never called in ExtensionMethodsDemo1, because each 
        //    // of the three classes A, B, and C implements a method named MethodB
        //    // that has a matching signature.
        //    public static void MethodB(this IMyInterface myInterface)
        //    {
        //        Console.WriteLine
        //            ("Extension.MethodB(this IMyInterface myInterface)");
        //    }
        //}
        //}


        //// Define three classes that implement IMyInterface, and then use them to test
        //// the extension methods.
        //namespace ExtensionMethodsDemo1
        //{
        //using System;
        //using Extensions;
        //using DefineIMyInterface;

        //class A : IMyInterface
        //{
        //    public void MethodB() { Console.WriteLine("A.MethodB()"); }
        //}

        //class B : IMyInterface
        //{
        //    public void MethodB() { Console.WriteLine("B.MethodB()"); }
        //    public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
        //}

        //class C : IMyInterface
        //{
        //    public void MethodB() { Console.WriteLine("C.MethodB()"); }
        //    public void MethodA(object obj)
        //    {
        //        Console.WriteLine("C.MethodA(object obj)");
        //    }
        //}

        //class ExtMethodDemo
        //{
        //    static void Main(string[] args)
        //    {
        //        // Declare an instance of class A, class B, and class C.
        //        A a = new A();
        //        B b = new B();
        //        C c = new C();

        //        // For a, b, and c, call the following methods:
        //        //      -- MethodA with an int argument
        //        //      -- MethodA with a string argument
        //        //      -- MethodB with no argument.

        //        // A contains no MethodA, so each call to MethodA resolves to 
        //        // the extension method that has a matching signature.
        //        a.MethodA(1);           // Extension.MethodA(IMyInterface, int)
        //        a.MethodA("hello");     // Extension.MethodA(IMyInterface, string)

        //        // A has a method that matches the signature of the following call
        //        // to MethodB.
        //        a.MethodB();            // A.MethodB()

        //        // B has methods that match the signatures of the following
        //        // method calls.
        //        b.MethodA(1);           // B.MethodA(int)
        //        b.MethodB();            // B.MethodB()

        //        // B has no matching method for the following call, but 
        //        // class Extension does.
        //        b.MethodA("hello");     // Extension.MethodA(IMyInterface, string)

        //        // C contains an instance method that matches each of the following
        //        // method calls.
        //        c.MethodA(1);           // C.MethodA(object)
        //        c.MethodA("hello");     // C.MethodA(object)
        //        c.MethodB();            // C.MethodB()
        //    }
        //}
        //}
        ///* Output:
        //Extension.MethodA(this IMyInterface myInterface, int i)
        //Extension.MethodA(this IMyInterface myInterface, string s)
        //A.MethodB()
        //B.MethodA(int i)
        //B.MethodB()
        //Extension.MethodA(this IMyInterface myInterface, string s)
        //C.MethodA(object obj)
        //C.MethodA(object obj)
        //C.MethodB()
        //*/
        //Diretrizes gerais
        //Em geral, recomendamos que você implemente métodos de extensão com parcimônia e somente quando for necessário.Sempre que possível, o código do cliente que deve estender um tipo existente deve fazer isso ao criar um novo tipo derivado do tipo existente.Para obter mais informações, consulte Herança.


        //Ao usar um método de extensão para estender um tipo cujo código-fonte você não pode alterar, há o risco de uma alteração na implementação do tipo fazer com que o método de extensão interrompa.

        //Se você implementar métodos de extensão para um determinado tipo, lembre-se das seguintes considerações:


        //Um método de extensão nunca será chamado se possuir a mesma assinatura que um método definido no tipo.


        //Os métodos de extensão são trazidos para o escopo no nível do namespace.Por exemplo, se você tiver várias classes estáticas que contenham métodos de extensão em um único namespace chamado Extensions, todos eles serão trazidos para o escopo pela diretiva using Extensions;.

        //Para uma biblioteca de classes que você implemente, não use métodos de extensão para evitar incrementar o número de versão de um assembly.Se desejar adicionar funcionalidade significativa a uma biblioteca da qual você possua o código-fonte, siga as diretrizes padrão do .NET Framework para controle de versão do assembly.Para obter mais informações, consulte Controle de versão do assembly.
    }
}
