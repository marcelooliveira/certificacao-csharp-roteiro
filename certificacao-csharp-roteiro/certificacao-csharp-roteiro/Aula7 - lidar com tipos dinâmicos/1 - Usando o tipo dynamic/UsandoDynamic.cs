using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            // O C# 4 apresenta um novo tipo, dynamic. O tipo é um tipo estático, mas um objeto do tipo 
            // dynamic ignora a verificação de tipo estático. Na maioria dos casos, ele funciona como se 
            // tivesse o tipo object. Em tempo de compilação, supõem-se que um elemento que tem o tipo 
            // dynamic dá suporte a qualquer operação. Portanto, você não precisa se preocupar se o objeto 
            // obtém seu valor de uma API COM, de uma linguagem dinâmica como o IronPython, do HTML DOM 
            // (Modelo de Objeto do Documento), a reflexão ou de algum outro lugar no programa. No entanto,
            // se o código não for válido, os erros serão capturados em tempo de execução.

            // Por exemplo, se método de instância Somar no código a seguir tiver apenas um 
            // parâmetro, o compilador reconhecerá que a primeira chamada para o método, calculadora.Somar
            // (10, 4), não é válido porque ele contém dois argumentos.Essa chamada causa um erro do 
            // compilador.A segunda chamada para o método, dynamic_calculadora.Somar(10, 4), não é verificada 
            // pelo compilador porque o tipo de dynamic_ec é dynamic.Portanto, nenhum erro de compilador é 
            // relatado. No entanto, o erro não escapa o aviso indefinidamente.Ele é detectado em tempo de 
            // execução e causa uma exceção de tempo de execução.

            AppCalculadora calculadora = new AppCalculadora();
            // The following call to Somar causes a compiler error 
            // if Somar has only one parameter. Uncomment the line
            // to see the error.
            //calculadora.Somar(10, 4);

            dynamic dynamic_calculadora = new AppCalculadora();
            // The following line is not identified as an error by the
            // compiler, but it causes a run-time exception.
            dynamic_calculadora.Somar(10, 4);

            // The following calls also do not cause compiler errors, whether 
            // appropriate methods exist or not.
            dynamic_calculadora.someMethod("some argument", 7, null);
            dynamic_calculadora.nonexistentMethod();







            dynamic d = 1;
            var testSum = d + 3;
            // Rest the mouse pointer over testSum in the following statement.
            Console.WriteLine(testSum);



            var testInstance = new AppCalculadora(d);
        }
    }

    class AppCalculadora
    {
        private decimal valor;

        public AppCalculadora() { }
        public AppCalculadora(decimal valorInicial)
        {
            this.valor = valorInicial;
        }

        public void Somar(decimal parcela)
            { this.valor += parcela; }

        public void Subtrair(decimal minuendo)
            { this.valor -= minuendo; }
    }
}
