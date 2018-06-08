using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Delegates : IAulaItem
    {
        //A declaração de um tipo de delegado é semelhante a uma assinatura de método.
        //Ela tem um valor retornado e parâmetros de qualquer tipo:

        //public delegate void TestDelegate(string message);
        //public delegate int TestDelegate(MyType m, long num);

        //Um delegate é um tipo de referência que pode ser usado para encapsular um método nomeado 
        //ou anônimo. Representantes são semelhantes a ponteiros de função em C++. 
        //No entanto, os representantes são fortemente tipados e seguros.
        //Para aplicativos de representantes, consulte Representantes e Representantes genéricos.

        //Os representantes são a base dos Eventos.


        //Um delegado pode ser instanciado associando-o a um método nomeado ou anônimo.
        //Para obter mais informações, consulte Métodos anônimos e Métodos nomeados.


        //O delegado deve ser instanciado com um método ou expressão lambda que tenha um tipo de retorno
        //compatível e parâmetros de entrada. Para obter mais informações sobre o grau de variação 
        //permitido na assinatura do método, consulte Variação em representantes. 
        //Para uso com métodos anônimos, o delegado e o código a ser associado a ele são declarados juntos.
        //As duas formas de instanciar representantes são discutidas nesta seção.

        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    //class Calculadora
    //{
    //    static double Duplicar(double input) { return input * 2; }
    //    static double Triplicar(double input) { return input * 3; }

    //    public static void Executar()
    //    {
    //        //Executa diretamente o método
    //        Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

    //        //Executa diretamente o método
    //        Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");
    //    }
    //}

    // Declara o delegado e define a assinatura exigida
    delegate double OperacaoMatematica(double num);

    //class Calculadora
    //{
    //    static double Duplicar(double input) { return input * 2; }
    //    static double Triplicar(double input) { return input * 3; }

    //    public static void Executar()
    //    {
    //        //Executa diretamente o método
    //        Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

    //        //Executa diretamente o método
    //        Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

    //        OperacaoMatematica metodoMultiplicacao = Duplicar;
    //        Console.WriteLine($"Duplicar(7.5): {metodoMultiplicacao(7.5)}");
    //        metodoMultiplicacao = Triplicar;
    //        Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");
    //    }
    //}

    class Calculadora
    {
        static double Duplicar(double input) { return input * 2; }
        static double Triplicar(double input) { return input * 3; }

        public static void Executar()
        {
            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            //invoca o delegado
            OperacaoMatematica metodoMultiplicacao = Duplicar;
            Console.WriteLine($"Duplicar(7.5): {metodoMultiplicacao(7.5)}");

            //troca a referência
            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");

            // instancia um delegado com um método anônimo
            OperacaoMatematica metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine("quadrado: {0}", quadrado);

            // intancia um delegado com uma expressão lambda
            OperacaoMatematica metodoCubo = s => s * s * s;
            double cubo = metodoCubo(4.375);

            Console.WriteLine("cubo: {0}", cubo);
        }
    }
}
