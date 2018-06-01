using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Override
    {
        //O modificador override é necessário para estender ou modificar a implementação abstrata ou virtual de um método, propriedade, indexador ou evento herdado.

        //Exemplo
        //Neste exemplo, a classe Square deve fornecer uma implementação substituída de Area porque Area é herdado do ShapesClass abstrato:


        //C#

        //Copiar

        //abstract class ShapesClass
        //{
        //    abstract public int Area();
        //}
        //class Square : ShapesClass
        //{
        //    int side = 0;

        //    public Square(int n)
        //    {
        //        side = n;
        //    }
        //    // Area method is required to avoid
        //    // a compile-time error.
        //    public override int Area()
        //    {
        //        return side * side;
        //    }

        //    static void Main()
        //    {
        //        Square sq = new Square(12);
        //        Console.WriteLine("Area of the square = {0}", sq.Area());
        //    }

        //    interface I
        //    {
        //        void M();
        //    }
        //    abstract class C : I
        //    {
        //        public abstract void M();
        //    }

        //}
        //// Output: Area of the square = 144
        //Um método override fornece uma nova implementação de um membro herdado de uma classe base. O método que é substituído por uma declaração override é conhecido como o método base substituído.O método base substituído deve ter a mesma assinatura que o método override. Para obter informações sobre herança, consulte Herança.

        //Você não pode substituir um método não virtual ou estático.O método base substituído deve ser virtual, abstract ou override.

        //Uma declaração override não pode alterar a acessibilidade do método virtual. O método override e o método virtual devem ter o mesmo modificador de nível de acesso.

        //Não é possível usar os modificadores new, static ou virtual para modificar um método override.

        //Uma declaração de propriedade de substituição deve especificar exatamente o mesmo modificador de acesso, tipo e nome que a propriedade herdada e a propriedade substituída deve ser virtual, abstract ou override.

        //Para obter mais informações sobre como usar a palavra-chave override, consulte Controle de versão com as palavras-chave override e new e Quando usar as palavras-chave override e new.

        //Exemplo
        //Este exemplo define uma classe base chamada Employee e uma classe derivada chamada SalesEmployee.A classe SalesEmployee inclui uma propriedade extra, salesbonus e substitui o método CalculatePay para levar isso em consideração.

        //C#

        //Copiar
        //class TestOverride
        //{
        //    public class Employee
        //    {
        //        public string name;

        //        // Basepay is defined as protected, so that it may be 
        //        // accessed only by this class and derived classes.
        //        protected decimal basepay;

        //        // Constructor to set the name and basepay values.
        //        public Employee(string name, decimal basepay)
        //        {
        //            this.name = name;
        //            this.basepay = basepay;
        //        }

        //        // Declared virtual so it can be overridden.
        //        public virtual decimal CalculatePay()
        //        {
        //            return basepay;
        //        }
        //    }

        //    // Derive a new class from Employee.
        //    public class SalesEmployee : Employee
        //    {
        //        // New field that will affect the base pay.
        //        private decimal salesbonus;

        //        // The constructor calls the base-class version, and
        //        // initializes the salesbonus field.
        //        public SalesEmployee(string name, decimal basepay,
        //                    decimal salesbonus) : base(name, basepay)
        //        {
        //            this.salesbonus = salesbonus;
        //        }

        //        // Override the CalculatePay method 
        //        // to take bonus into account.
        //        public override decimal CalculatePay()
        //        {
        //            return basepay + salesbonus;
        //        }
        //    }

        //    static void Main()
        //    {
        //        // Create some new employees.
        //        SalesEmployee employee1 = new SalesEmployee("Alice",
        //                        1000, 500);
        //        Employee employee2 = new Employee("Bob", 1200);

        //        Console.WriteLine("Employee4 " + employee1.name +
        //                    " earned: " + employee1.CalculatePay());
        //        Console.WriteLine("Employee4 " + employee2.name +
        //                    " earned: " + employee2.CalculatePay());
        //    }
        //}
        ///*
        //    Output:
        //    Employee4 Alice earned: 1500
        //    Employee4 Bob earned: 1200
        //*/
    }
}
