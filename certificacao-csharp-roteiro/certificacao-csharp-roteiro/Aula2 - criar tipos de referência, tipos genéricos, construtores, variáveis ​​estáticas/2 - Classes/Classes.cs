using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Classes
    {
        //Classes(Guia de Programação em C#)
        //05/04/2018
        //10 minutos para ler
        //Colaboradores
        //dotnet bot  olprod OpenLocalizationService
        //Uma classe é um constructo que permite que você crie seus próprios tipos personalizados através do agrupamento de variáveis de outros tipos, métodos e eventos.Uma classe é como um plano gráfico.Ela define os dados e o comportamento de um tipo. Se a classe não for declarada como estática, o código cliente poderá criar instâncias dela.Essas instâncias são objetos que são atribuídos a uma variável. A instância de uma classe permanece na memória até que todas as referências a ela saiam do escopo.Nesse momento, o CLR marca a variável como qualificada para a coleta de lixo. Se a classe for declarada como estática, não será possível criar instâncias e o código cliente só poderá acessá-la por meio da própria classe. Para obter mais informações, consulte Classes estáticas e membros de classes estáticas.


        //Tipos de referência
        //Um tipo que é definido como uma classe é um tipo de referência. No tempo de execução, quando você declara uma variável de um tipo de referência, a variável contém o valor null até que você crie explicitamente uma instância da classe usando o operador new ou atribua a ela um objeto que foi criado em outro lugar, conforme mostrado no exemplo a seguir:
        //C#

        //Copiar
        //MyClass mc = new MyClass();
        //MyClass mc2 = mc;
        //Quando o objeto é criado, a memória é alocada no heap gerenciado e a variável contém apenas uma referência para o local do objeto.Os tipos no heap gerenciado requerem sobrecarga quando são alocados e quando são recuperados pela funcionalidade de gerenciamento automático de memória do CLR, que é conhecida como coleta de lixo.No entanto, a coleta de lixo também é altamente otimizada e na maioria dos cenários não cria problemas de desempenho.Para obter mais informações sobre a coleta de lixo, consulte Gerenciamento automático de memória e coleta de lixo.

        //Declarando Classes
        //As classes são declaradas usando a palavra-chave class, conforme mostrado no exemplo a seguir:
        //C#

        //Copiar
        //public class Customer
        //{
        //    // Fields, properties, methods and events go here...
        //}
        //A palavra-chave class é precedida pelo nível de acesso.Como público é usado nesse caso, qualquer pessoa pode criar instâncias dessa classe.O nome da classe segue a palavra-chave class. O restante da definição é o corpo da classe, em que o comportamento e os dados são definidos.Campos, propriedades, métodos e eventos em uma classe são coletivamente denominados de membros de classe.

        //Criando Objetos
        //Embora eles sejam usados algumas vezes de maneira intercambiável, uma classe e um objeto são coisas diferentes.Uma classe define um tipo de objeto, mas não é um objeto em si.Um objeto é uma entidade concreta com base em uma classe e, às vezes, é conhecido como uma instância de uma classe.

        //Os objetos podem ser criados usando a palavra-chave new, seguida pelo nome da classe na qual ele se baseará, dessa maneira:

        //C#

        //Copiar
        //Customer object1 = new Customer();
        //Quando uma instância de uma classe é criada, uma referência ao objeto é passada de volta para o programador.No exemplo anterior, object1 é uma referência a um objeto que é baseado em Customer. Esta referência refere-se ao novo objeto, mas não contém os dados de objeto.Na verdade, você pode criar uma referência de objeto sem criar um objeto:


        //C#

        //Copiar
        //Customer object2;
        //Não recomendamos a criação de referências de objeto como essa, que não faz referência a um objeto, porque tentar acessar um objeto por meio de uma referência desse tipo falhará em tempo de execução.Entretanto, essa referência pode ser feita para se referir a um objeto, criando um novo objeto ou atribuindo-a a um objeto existente, como abaixo:


        //C#

        //Copiar
        //Customer object3 = new Customer();
        //Customer object4 = object3;
        //Esse código cria duas referências de objeto que fazem referência ao mesmo objeto.Portanto, qualquer alteração no objeto feita por meio de object3 será refletida no usos posteriores de object4.Como os objetos que são baseados em classes são referenciados por referência, as classes são conhecidas como tipos de referência.

        //Herança da Classe
        //As classes dão suporte completo à herança, uma característica fundamental da programação orientada a objetos. Ao criar uma classe, você pode herdar de outra interface ou classe que não está definida como selada, e outras classes podem herdar de sua classe e substituir seus métodos virtuais.
        //A herança é realizada usando uma derivação, o que significa que uma classe é declarada usando uma classe base, da qual ela herda o comportamento e os dados.Uma classe base é especificada ao acrescentar dois-pontos e o nome de classe base depois do nome de classe derivada, dessa maneira:

        //C#

        //Copiar
        //public class Manager : Employee
        //{
        //    // Employee fields, properties, methods and events are inherited
        //    // New Manager fields, properties, methods and events go here...
        //}
        //Quando uma classe declara uma classe base, ela herda todos os membros da classe base, exceto os construtores.Para obter mais informações, consulte Herança.
        //Ao contrário do C++, uma classe no C# só pode herdar diretamente de uma classe base. No entanto, como uma classe base pode herdar de outra classe, uma classe pode herdar indiretamente várias classes base. Além disso, uma classe pode implementar diretamente mais de uma interface. Para obter mais informações, consulte Interfaces.

        //Uma classe pode ser declarada abstract. Uma classe abstrata contém métodos abstratos que têm uma definição de assinatura, mas não têm implementação.As classes abstratas não podem ser instanciadas.Elas só podem ser usadas por meio de classes derivadas que implementam os métodos abstratos.Por outro lado, uma classe lacrada não permite que outras classes sejam derivadas dela.Para obter mais informações, consulte Classes e Membros de Classes Abstratos e Lacrados.

        //As definições de classe podem ser divididas entre arquivos de origem diferentes.Para obter mais informações, consulte Classes e métodos parciais.

        //Exemplo
        //No exemplo a seguir, é definida uma classe pública que contém uma propriedade autoimplementada, um método e um método especial chamado construtor. Para obter mais informações, consulte os tópicos Propriedades, Métodos, e Construtores. As instâncias da classe são então instanciadas com a palavra-chave new.

        //C#

        //Copiar
        //public class Person
        //{
        //    // Constructor that takes no arguments:
        //    public Person()
        //    {
        //        Name = "unknown";
        //    }

        //    // Constructor that takes one argument:
        //    public Person(string name)
        //    {
        //        Name = name;
        //    }

        //    // Auto-implemented readonly property:
        //    public string Name { get; }

        //    // Method that overrides the base class (System.Object) implementation.
        //    public override string ToString()
        //    {
        //        return Name.ToString();
        //    }
        //}
        //class TestPerson
        //{
        //    static void Main()
        //    {
        //        // Call the constructor that has no parameters.
        //        var person1 = new Person();
        //        Console.WriteLine(person1.Name);

        //        // Call the constructor that has one parameter.
        //        var person2 = new Person("Sarah Jones");
        //        Console.WriteLine(person2.Name);
        //        // OR use ToString method to get string representation of the person2 instance:
        //        Console.WriteLine(person2.ToString());

        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //}
        //// Output:
        //// unknown
        //// Sarah Jones
        //// Sarah Jones
        //Especificação da Linguagem C#
        //Para obter mais informações, consulte a Especificação da linguagem C#. A especificação da linguagem é a fonte definitiva para a sintaxe e o uso de C#.
    }
}
