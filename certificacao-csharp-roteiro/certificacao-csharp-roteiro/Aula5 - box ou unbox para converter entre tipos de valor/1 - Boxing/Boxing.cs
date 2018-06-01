using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing
    {
        //Conversão boxing é o processo de conversão de um tipo de valor para o tipo object ou para qualquer tipo de interface implementada por esse tipo de valor.Quando o CLR realiza a conversão boxing de um tipo de valor, ele encapsula o valor dentro de System.Object e o armazena no heap gerenciado. A conversão unboxing extrai o tipo de valor do objeto.A conversão boxing é implícita, a conversão unboxing é explícita.O conceito de conversões boxing e unboxing serve como base para a exibição unificada de C# do sistema de tipos em que um valor de qualquer tipo pode ser tratado como um objeto.

        //No exemplo a seguir, a variável de inteiro i é submetida à conversão boxing e atribuída ao objeto o.

        //C#

        //Copiar
        //int i = 123;
        //// The following line boxes i.
        //object o = i;
        //O objeto o pode ser submetido à conversão unboxing e atribuído à variável de inteiro i:

        //C#

        //Copiar
        //o = 123;
        //i = (int) o;  // unboxing
        //Os exemplos a seguir ilustram como a conversão boxing é usada em C#.

        //C#

        //Copiar
        //// String.Concat example.
        //// String.Concat has many versions. Rest the mouse pointer on 
        //// Concat in the following statement to verify that the version
        //// that is used here takes three object arguments. Both 42 and
        //// true must be boxed.
        //Console.WriteLine(String.Concat("Answer", 42, true));


        //// List example.
        //// Create a list of objects to hold a heterogeneous collection 
        //// of elements.
        //List<object> mixedList = new List<object>();

        //// Add a string element to the list. 
        //mixedList.Add("First Group:");

        //// Add some integers to the list. 
        //for (int j = 1; j< 5; j++)
        //{
        //// Rest the mouse pointer over j to verify that you are adding
        //// an int to a list of objects. Each element j is boxed when 
        //// you add j to mixedList.
        //mixedList.Add(j);
        //}

        //// Add another string and more integers.
        //mixedList.Add("Second Group:");
        //for (int j = 5; j< 10; j++)
        //{
        //mixedList.Add(j);
        //}

        //// Display the elements in the list. Declare the loop variable by 
        //// using var, so that the compiler assigns its type.
        //foreach (var item in mixedList)
        //{
        //// Rest the mouse pointer over item to verify that the elements
        //// of mixedList are objects.
        //Console.WriteLine(item);
        //}

        //// The following loop sums the squares of the first group of boxed
        //// integers in mixedList. The list elements are objects, and cannot
        //// be multiplied or added to the sum until they are unboxed. The
        //// unboxing must be done explicitly.
        //var sum = 0;
        //for (var j = 1; j< 5; j++)
        //{
        //// The following statement causes a compiler error: Operator 
        //// '*' cannot be applied to operands of type 'object' and
        //// 'object'. 
        ////sum += mixedList[j] * mixedList[j]);

        //// After the list elements are unboxed, the computation does 
        //// not cause a compiler error.
        //sum += (int) mixedList[j] * (int) mixedList[j];
        //}

        //// The sum displayed is 30, the sum of 1 + 4 + 9 + 16.
        //Console.WriteLine("Sum: " + sum);

        //// Output:
        //// Answer42True
        //// First Group:
        //// 1
        //// 2
        //// 3
        //// 4
        //// Second Group:
        //// 5
        //// 6
        //// 7
        //// 8
        //// 9
        //// Sum: 30
        //Desempenho
        //Em relação às atribuições simples, as conversões boxing e unboxing são processos computacionalmente dispendiosos.Quando um tipo de valor é submetido à conversão boxing, um novo objeto deve ser alocado e construído. A um grau menor, a conversão necessária para a conversão unboxing também é computacionalmente dispendiosa.Para obter mais informações, consulte Desempenho.

        //Boxing
        //A conversão boxing é usada para armazenar tipos de valor no heap coletado como lixo. A conversão boxing é uma conversão implícita de um tipo de valor para o tipo object ou para qualquer tipo de interface implementada por esse tipo de valor.A conversão boxing de um tipo de valor aloca uma instância de objeto no heap e copia o valor no novo objeto.

        //Considere a seguinte declaração de uma variável de tipo de valor:


        //C#

        //Copiar
        //int i = 123;
        //A instrução a seguir aplica implicitamente a operação de conversão boxing na variável i:

        //C#

        //Copiar
        //// Boxing copies the value of i into object o.
        //object o = i;
        //O resultado dessa instrução é a criação de uma referência de objeto o, na pilha, que faz referência a um valor do tipo int, no heap.Esse valor é uma cópia do valor do tipo de valor atribuído à variável i.A diferença entre as duas variáveis, i e o, é ilustrada na figura a seguir.

        //Gráfico de Conversão Boxing
        //Conversão boxing

        //Também é possível executar a conversão boxing explicitamente como no exemplo a seguir, mas a conversão boxing explícita nunca é necessária:

        //C#

        //Copiar
        //int i = 123;
        //object o = (object)i;  // explicit boxing
        //Descrição
        //Este exemplo converte uma variável de inteiro i em um objeto o usando a conversão boxing.Em seguida, o valor armazenado na variável i é alterado de 123 para 456. O exemplo mostra que o tipo do valor original e o objeto submetido à conversão boxing usa locais de memória separados e, portanto, pode armazenar valores diferentes.

        //Exemplo
        //C#

        //Copiar
        //class TestBoxing
        //{
        //static void Main()
        //{
        //int i = 123;

        //// Boxing copies the value of i into object o.
        //object o = i;

        //// Change the value of i.
        //i = 456;

        //// The change in i doesn't affect the value stored in o.
        //System.Console.WriteLine("The value-type value = {0}", i);
        //System.Console.WriteLine("The object-type value = {0}", o);
        //}
        //}
        ///* Output:
        //The value-type value = 456
        //The object-type value = 123
        //*/
    }
}
