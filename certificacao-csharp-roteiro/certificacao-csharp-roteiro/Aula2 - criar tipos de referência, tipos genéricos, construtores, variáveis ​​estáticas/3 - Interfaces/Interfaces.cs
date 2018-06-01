using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces
    {
        //Interfaces(Guia de Programação em C#)
        //20/07/2015
        //8 minutos para ler
        //Colaboradores
        //dotnet bot  olprod OpenLocalizationService
        //Uma interface contém definições para um grupo de funcionalidades relacionadas que uma classe ou um struct pode implementar.

        //Usando interfaces, você pode, por exemplo, incluir o comportamento de várias fontes em uma classe.Essa funcionalidade é importante em C# porque a linguagem não dá suporte a várias heranças de classes. Além disso, use uma interface se você deseja simular a herança para structs, pois eles não podem herdar de outro struct ou classe.

        //Você define uma interface usando a palavra-chave interface, como mostra o exemplo a seguir.

        //C#

        //Copiar
        //interface IEquatable<T>
        //{
        //    bool Equals(T obj);
        //}
        //Qualquer classe ou struct que implemente a interface IEquatable<T> deve conter uma definição para um método Equals que corresponda à assinatura que a interface especifica. Como resultado, você pode contar com uma classe que implementa IEquatable<T> para conter um método Equals com o qual uma instância da classe pode determinar se é igual a outra instância da mesma classe.

        //A definição de IEquatable<T> não fornece uma implementação para Equals. A interface define somente a assinatura.Dessa forma, uma interface em C# é semelhante a uma classe abstrata, na qual todos os métodos são abstratos. No entanto, uma classe ou struct pode implementar várias interfaces, mas uma classe pode herdar apenas uma única classe, abstrata ou não. Assim, ao usar interfaces, você pode incluir o comportamento de várias fontes em uma classe.

        //Para obter mais informações sobre classes abstratas, consulte Classes e membros de classes abstratos e lacrados.

        //As interfaces podem conter métodos, propriedades, eventos, indexadores ou qualquer combinação desses quatro tipos de membro.Para obter links para exemplos, consulte as seções relacionadas. Uma interface não pode conter constantes, campos, operadores, construtores de instância, finalizadores ou tipos.Os membros da interface são automaticamente públicos e eles não podem incluir nenhum modificador de acesso.Os membros também não podem ser estáticos.

        //Para implementar um membro de interface, o membro correspondente da classe de implementação deve ser público, não estático e ter o mesmo nome e assinatura do membro de interface.

        //Quando uma classe ou struct implementa uma interface, a classe ou o struct deve fornecer uma implementação para todos os membros que a interface define. A interface não fornece nenhuma funcionalidade que uma classe ou um struct possa herdar da forma que ela pode herdar a funcionalidade da classe base. No entanto, se uma classe base implementa uma interface, qualquer classe que é derivada da classe base herda essa implementação.

        //O exemplo a seguir mostra uma implementação da interface IEquatable<T>. A classe de implementação, Car, deverá fornecer uma implementação do método Equals.

        //C#

        //Copiar
        //public class Car : IEquatable<Car>
        //{
        //    public string Make { get; set; }
        //    public string Model { get; set; }
        //    public string Year { get; set; }

        //    // Implementation of IEquatable<T> interface
        //    public bool Equals(Car car)
        //    {
        //        if (this.Make == car.Make &&
        //            this.Model == car.Model &&
        //            this.Year == car.Year)
        //        {
        //            return true;
        //        }
        //        else
        //            return false;
        //    }
        //}
        //As propriedades e os indexadores de uma classe podem definir acessadores extras para uma propriedade ou o indexador que é definido em uma interface. Por exemplo, uma interface pode declarar uma propriedade que tem um acessador get.A classe que implementa a interface pode declarar a mesma propriedade tanto com um acessador get quanto com um set.No entanto, se a propriedade ou o indexador usa a implementação explícita, os acessadores devem corresponder.Para obter mais informações sobre a implementação explícita, consulte Implementação de interface explícita e Propriedades da interface.

        //As interfaces podem implementar outras interfaces.Uma classe pode incluir uma interface várias vezes por meio das classes base que ela herda ou por meio de interfaces que outras interfaces implementam.No entanto, a classe poderá fornecer uma implementação de uma interface apenas uma vez e somente se a classe declarar a interface como parte da definição de classe(class ClassName : InterfaceName). Se a interface é herdada porque é herdada de uma classe base que implementa a interface, a classe base fornece a implementação dos membros da interface. No entanto, a classe derivada pode reimplementar os membros de interface em vez de usar a implementação herdada.

        //Uma classe base também pode implementar membros de interface usando membros virtuais.Nesse caso, uma classe derivada pode alterar o comportamento da interface substituindo os membros virtuais.Para obter mais informações sobre membros virtuais, consulte Polimorfismo.

        //Resumo de Interfaces
        //Uma interface tem as propriedades a seguir:

        //Uma interface é como uma classe base abstrata.Qualquer classe ou struct que implementa a interface deve implementar todos os seus membros.

        //Uma interface não pode ser instanciada diretamente.Seus membros são implementados por qualquer classe ou struct que implemente a interface.

        //As interfaces podem conter propriedades, indexadores, métodos e eventos.

        //As interfaces não têm implementações de métodos.

        //Uma classe ou struct pode implementar várias interfaces.Uma classe pode herdar uma classe base e também implementar uma ou mais interfaces.
    }
}
