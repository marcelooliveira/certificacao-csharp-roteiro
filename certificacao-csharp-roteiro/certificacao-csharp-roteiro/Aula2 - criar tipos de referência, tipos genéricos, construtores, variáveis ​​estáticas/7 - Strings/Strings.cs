using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Strings
    {
        //string (Referência de C#)
        //20/07/2015
        //4 minutos para ler
        //Colaboradores
        //dotnet bot  olprod OpenLocalizationService
        //O tipo string representa uma sequência de zero ou mais caracteres Unicode. string é um alias de String no.NET.

        //Embora string seja um tipo de referência, os operadores de igualdade (== e !=) são definidos para comparar os valores dos objetos string, não referências.Isso torna o teste de igualdade de cadeia de caracteres mais intuitivo.Por exemplo:

        //C#

        //Copiar
        //string a = "hello";
        //string b = "h";
        //// Append to contents of 'b'  
        //b += "ello";  
        //Console.WriteLine(a == b);  
        //Console.WriteLine((object) a == (object) b);
        //Isso exibe "True" e, em seguida, "False" porque os conteúdos das cadeias de caracteres são equivalentes, mas a e b não fazem referência à mesma instância da cadeia de caracteres.

        //O operador + concatena as cadeias de caracteres:


        //C#

        //Copiar
        //string a = "good " + "morning";
        //Isso cria um objeto de cadeia de caracteres que contém “good morning”.

        //Cadeias de caracteres são imutável – o conteúdo de um objeto de cadeia de caracteres não pode ser alterado depois que o objeto é criado, embora a sintaxe faça com que pareça que você pode fazer isso.Por exemplo, quando você escreve esse código, o compilador na verdade cria um novo objeto de cadeia de caracteres para manter a nova sequência de caracteres e esse novo objeto é atribuído a b.A cadeia de caracteres "h" é então qualificada para coleta de lixo.

        //C#

        //Copiar
        //string b = "h";
        //b += "ello";  
        //O operador[] pode ser usado para o acesso somente leitura a caracteres individuais de uma string:

        //C#

        //Copiar
        //string str = "test";
        //char x = str[2];  // x = 's';  
        //Literais de cadeia de caracteres são do tipo string e podem ser escritos de duas formas, entre aspas e @-quoted.Os literais de cadeia de caracteres entre aspas são colocados entre aspas duplas("):

        //C#

        //Copiar
        //"good morning"  // a string literal  
        //Os literais de cadeia de caracteres podem conter qualquer literal de caractere. Sequências de escape são incluídas.O exemplo a seguir usa a sequência de escape \\ de barra invertida, \u0066 para a letra f e \n para a nova linha.

        //C#

        //Copiar
        //string a = "\\\u0066\n";
        //Console.WriteLine(a);  
        //Observação

        //O código de escape \udddd (em que dddd é um número de quatro dígitos) representa o caractere Unicode U+dddd.Os códigos de escape Unicode de oito dígitos também são reconhecidos: \Udddddddd.

        //Os literais de cadeia de caracteres textuais começam com @ e também são colocados entre aspas duplas.Por exemplo:

        //C#

        //Copiar
        //@"good morning"  // a string literal  
        //A vantagem das cadeias de caracteres textuais é que as sequências de escape não são processadas, o que torna mais fácil escrever, por exemplo, um nome de arquivo totalmente qualificado:

        //C#

        //Copiar
        //@"c:\Docs\Source\a.txt"  // rather than "c:\\Docs\\Source\\a.txt"  
        //Para incluir aspas duplas em uma cadeia de caracteres @-quoted, dobre-a:

        //C#

        //Copiar
        //@"""Ahoy!"" cried the captain." // "Ahoy!" cried the captain.  
        //Para saber outras formas de usar o caractere especial @, confira @ – identificador textual.

        //Para obter mais informações sobre cadeias de caracteres, consulte Cadeias de caracteres.

        //Exemplo
        //C#

        //Copiar
        //class SimpleStringTest
        //{
        //    static void Main()
        //    {
        //        string a = "\u0068ello ";
        //        string b = "world";
        //        Console.WriteLine(a + b);
        //        Console.WriteLine(a + b == "Hello World"); // == performs a case-sensitive comparison
        //    }
        //}
        ///* Output:
        //    hello world
        //    False
        //    */
    }
}
