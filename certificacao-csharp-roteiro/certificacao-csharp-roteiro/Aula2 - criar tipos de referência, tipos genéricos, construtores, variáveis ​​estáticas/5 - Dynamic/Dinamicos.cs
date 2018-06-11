using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        //O tipo dynamic habilita operações nas quais ele ocorre para ignorar a verificação de tipo em 
        //tempo de compilação.Em vez disso, essas operações são resolvidas em tempo de execução.
        //O tipo dynamic simplifica o acesso a APIs COM, como as APIs de Automação do Office e também 
        //às APIs dinâmicas, como bibliotecas do IronPython e ao Modelo de Objeto do Documento (DOM) 
        //do HTML.

        //O tipo dynamic se comporta como o tipo object na maioria das circunstâncias.No entanto, as 
        //operações que contêm expressões do tipo dynamic não são resolvidas ou verificadas pelo compilador.
        //O compilador junta as informações sobre a operação em pacotes e, posteriormente, essas 
        //informações são usadas para avaliar a operação em tempo de execução. Como parte do processo, 
        //as variáveis do tipo dynamic são compiladas em variáveis do tipo object. Portanto, o tipo 
        //dynamic existe somente em tempo de compilação e não em tempo de execução.

        //O exemplo a seguir compara uma variável do tipo dynamic a uma variável do tipo object. Para 
        //verificar o tipo de cada variável no tempo de compilação, coloque o ponteiro do mouse sobre dyn 
        //ou obj nas instruções WriteLine. O IntelliSense mostra dinâmico para dyn e objeto para obj.



        //Para ver a diferença entre dyn e obj em tempo de compilação, adicione as duas linhas a seguir 
        //entre as declarações e as instruções WriteLine no exemplo anterior.

        //dyn = dyn + 3;
        //obj = obj + 3;  
        //Um erro de compilador será relatado em virtude da tentativa de adição de um inteiro e um objeto 
        //à expressão obj + 3. No entanto, nenhum erro será relatado para dyn + 3. A expressão contém dyn 
        //não é verificada em tempo de compilação, pois o tipo de dyn é dynamic.

        //Contexto
        //A palavra-chave dynamic pode aparecer diretamente ou como um componente de um tipo construído
        //nas seguintes situações:

        //Em declarações, como o tipo de uma propriedade, campo, indexador, parâmetro, valor retornado, 
        //variável local ou restrição de tipo.A definição de classe a seguir usa dynamic em várias declarações
        //diferentes.

        //class ExampleClass
        //{
        //    // A dynamic field.
        //    static dynamic field;

        //    // A dynamic property.
        //    dynamic prop { get; set; }

        //    // A dynamic return type and a dynamic parameter type.
        //    public dynamic exampleMethod(dynamic d)
        //    {
        //        // A dynamic local variable.
        //        dynamic local = "Local variable";
        //        int two = 2;

        //        if (d is int)
        //        {
        //            return local;
        //        }
        //        else
        //        {
        //            return two;
        //        }
        //    }
        //}
        //Em conversões explícitas de tipo, como o tipo de destino de uma conversão.

        //static void convertToDynamic()
        //{
        //    dynamic d;
        //    int i = 20;
        //    d = (dynamic)i;
        //    Console.WriteLine(d);

        //    string s = "Example string.";
        //    d = (dynamic)s;
        //    Console.WriteLine(d);

        //    DateTime dt = DateTime.Today;
        //    d = (dynamic)dt;
        //    Console.WriteLine(d);

        //}
        //// Results:
        //// 20
        //// Example string.
        //// 2/17/2009 9:12:00 AM
        //Em qualquer contexto em que tipos sirvam como valores, como no lado direito de um operador is 
        //ou um operador as ou como o argumento para typeof como parte de um tipo construído.
        //Por exemplo, dynamic pode ser usado nas expressões a seguir.


        //int i = 8;
        //dynamic d;
        //// With the is operator.
        //// The dynamic type behaves like object. The following
        //// expression returns true unless someVar has the value null.
        //if (someVar is dynamic) { }

        //// With the as operator.
        //d = i as dynamic;

        //// With typeof, as part of a constructed type.
        //Console.WriteLine(typeof(List<dynamic>));

        //// The following statement causes a compiler error.
        ////Console.WriteLine(typeof(dynamic));
        //Exemplo
        //O exemplo a seguir usa dynamic em várias declarações.O método Main também compara a verificação
        //de tipo em tempo de compilação com a verificação de tipo em tempo de execução.

        //using System;

        //namespace DynamicExamples
        //{
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        ExampleClass ec = new ExampleClass();
        //        Console.WriteLine(ec.exampleMethod(10));
        //        Console.WriteLine(ec.exampleMethod("value"));

        //        // The following line causes a compiler error because exampleMethod
        //        // takes only one argument.
        //        //Console.WriteLine(ec.exampleMethod(10, 4));

        //        dynamic dynamic_ec = new ExampleClass();
        //        Console.WriteLine(dynamic_ec.exampleMethod(10));

        //        // Because dynamic_ec is dynamic, the following call to exampleMethod
        //        // with two arguments does not produce an error at compile time.
        //        // However, itdoes cause a run-time error. 
        //        //Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        //    }
        //}

        //class ExampleClass
        //{
        //    static dynamic field;
        //    dynamic prop { get; set; }

        //    public dynamic exampleMethod(dynamic d)
        //    {
        //        dynamic local = "Local variable";
        //        int two = 2;

        //        if (d is int)
        //        {
        //            return local;
        //        }
        //        else
        //        {
        //            return two;
        //        }
        //    }
        //}
        //}
        //// Results:
        //// Local variable
        //// 2
        //// Local variable
        public void Executar()
        {
            dynamic dyn = 1;
            object obj = 1;

            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            System.Console.WriteLine(dyn.GetType());
            System.Console.WriteLine(obj.GetType());

            //As instruções WriteLine exibem os tipos de tempo de execução de dyn e obj.Nesse ponto, ambos 
            //têm o mesmo tipo, inteiro.A saída a seguir será produzida:
            //System.Int32
            //System.Int32

            dyn = dyn + 3;
            //obj = obj + 3;
            //Error CS0019  Operator '+' cannot be applied to operands of type 'object' and 'int'

            Console.WriteLine("convertToDynamic");
            dynamic d;
            int i = 20;
            d = (dynamic)i;
            Console.WriteLine(d);

            string s = "Example string.";
            d = (dynamic)s;
            Console.WriteLine(d);

            DateTime dt = DateTime.Today;
            d = (dynamic)dt;
            Console.WriteLine(d);
        }
    }

    class ExemploDinamico
    {
        // A dynamic field.
        static dynamic field;

        // A dynamic property.
        dynamic prop { get; set; }

        // A dynamic return type and a dynamic parameter type.
        public dynamic exampleMethod(dynamic d)
        {
            // A dynamic local variable.
            dynamic local = "Local variable";
            int two = 2;

            if (d is int)
            {
                return local;
            }
            else
            {
                return two;
            }
        }
    }

}
