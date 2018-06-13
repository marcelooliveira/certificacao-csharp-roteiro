using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            //Conversão boxing é o processo de conversão de um tipo de valor para o tipo object ou para qualquer tipo de interface implementada por esse tipo de valor.Quando o CLR realiza a conversão boxing de um tipo de valor, ele encapsula o valor dentro de System.Object e o armazena no heap gerenciado. A conversão unboxing extrai o tipo de valor do objeto.A conversão boxing é implícita, a conversão unboxing é explícita.O conceito de conversões boxing e unboxing serve como base para a exibição unificada de C# do sistema de tipos em que um valor de qualquer tipo pode ser tratado como um objeto.

            //No exemplo a seguir, a variável de inteiro i é submetida à conversão boxing e atribuída ao objeto o.

            int i = 123;
            // nesta linha, i está sofrendo boxing
            object o = i;
            //O objeto o pode ser submetido à conversão unboxing e atribuído à variável de inteiro i:

            o = 123;
            i = (int)o;  // unboxing
            //Os exemplos a seguir ilustram como a conversão boxing é usada em C#.

            // Exemplo de String.Concat.
            // String.Concat tem muitas versões. 
            // Coloque o mouse sobre Concat na próxima instrçuão para verificar
            // que a versão do método aqui recebe 3 argumentos. Tanto 42 quanto true
            // precisam passar por boxing
            Console.WriteLine(String.Concat("Resposta", 42, true));


            // Exemplo de lista.
            // Cria uma lista de objetos para conter uma coleção mista de elementos
            List<object> listaMista = new List<object>();

            //// Adiciona um elemento string à lista 
            listaMista.Add("Primeiro Grupo:");

            // Adiciona alguns inteiros à lista
            for (int j = 1; j < 5; j++)
            {
                //Coloque o mouse sobre o j para verificar que você está adicionando
                //um int a uma lista de objetos. Cada elemento j passa por boxing quando
                //você adiciona j à lista mista
                listaMista.Add(j);
            }

            // Adiciona outra string e mais inteiros
            listaMista.Add("Segundo Grupo:");
            for (int j = 5; j < 10; j++)
            {
                listaMista.Add(j);
            }

            // Exibe os elementos na lista. Declara a variável de loop usando var,
            // para que o compilador decida o seu tipo
            foreach (var item in listaMista)
            {
                //Deixa o mouse em cima do item para verifiar que os elementos
                // da lista mista são objetos
                Console.WriteLine(item);
            }

            // O seguinte loop soma os quadrados do primeiro grupo de inteiros
            //"boxed" na lista mista. Os elementos da lista são objetos, e não
            //podem ser multiplicados ou somados à soma até que passem por unboxing.
            //O processo de unboxing deve ser feito explicitamente
            var soma = 0;
            for (var j = 1; j < 5; j++)
            {
                // A instrução seguinte provoca um erro de compilação: Operator 
                // '*' cannot be applied to operands of type 'object' and
                // 'object'. 
                //sum += mixedList[j] * mixedList[j]);

                // Depois que os elementos da lista passam por unboxing, o cálculo
                // não produz um erro
                soma += (int)listaMista[j] * (int)listaMista[j];
            }

            // A soma exibida é 30, que é a soma de 1 + 4 + 9 + 16.
            Console.WriteLine("Soma: " + soma);

            //// Resultado:
            //// Resposta42True
            //// Primeiro Grupo:
            //// 1
            //// 2
            //// 3
            //// 4
            //// Segundo Grupo:
            //// 5
            //// 6
            //// 7
            //// 8
            //// 9
            //// Soma: 30
            //Desempenho
            //Em relação às atribuições simples, as conversões boxing e unboxing são processos computacionalmente dispendiosos.Quando um tipo de valor é submetido à conversão boxing, um novo objeto deve ser alocado e construído. A um grau menor, a conversão necessária para a conversão unboxing também é computacionalmente dispendiosa.Para obter mais informações, consulte Desempenho.

            //Boxing
            //A conversão boxing é usada para armazenar tipos de valor no heap coletado como lixo. A conversão boxing é uma conversão implícita de um tipo de valor para o tipo object ou para qualquer tipo de interface implementada por esse tipo de valor.A conversão boxing de um tipo de valor aloca uma instância de objeto no heap e copia o valor no novo objeto.

            //Considere a seguinte declaração de uma variável de tipo de valor:

            //int i = 123;
            //A instrução a seguir aplica implicitamente a operação de conversão boxing na variável i:

            //// O boxing copia o valor de i para o objeto o
            //object o = i;
            //O resultado dessa instrução é a criação de uma referência de objeto o, na pilha, que faz referência a um valor do tipo int, no heap.Esse valor é uma cópia do valor do tipo de valor atribuído à variável i.A diferença entre as duas variáveis, i e o, é ilustrada na figura a seguir.

            //Gráfico de Conversão Boxing
            //Conversão boxing

            //Também é possível executar a conversão boxing explicitamente como no exemplo a seguir, mas a conversão boxing explícita nunca é necessária:

            int i2 = 123;
            object o2 = (object)i2;  // boxing explicito
            //Descrição
            //Este exemplo converte uma variável de inteiro i em um objeto o usando a conversão boxing.Em seguida, o valor armazenado na variável i é alterado de 123 para 456. O exemplo mostra que o tipo do valor original e o objeto submetido à conversão boxing usa locais de memória separados e, portanto, pode armazenar valores diferentes.

            //Exemplo
            ///* Resultado:
            //O valor do tipo de valor = 456
            //O valor do tipo de referência = 123
            //*/

            TesteBoxing testeBoxing = new TesteBoxing();
        }
    }

    class TesteBoxing
    {
        public TesteBoxing()
        {
            int i = 123;

            // O "boxing" copia o valor de i para o objeto o
            object o = i;

            // Altera o valor de i
            i = 456;

            // A alteração em i não afeta o valor armazenado em o.
            System.Console.WriteLine("O valor do tipo de valor = {0}", i);
            System.Console.WriteLine("O valor do tipo de referência = {0}", o);
        }
    }
}
