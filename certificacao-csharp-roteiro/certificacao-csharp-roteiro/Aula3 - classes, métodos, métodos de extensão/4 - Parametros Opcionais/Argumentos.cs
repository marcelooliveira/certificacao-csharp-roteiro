using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Argumentos
    {
        //Os argumentos nomeados e opcionais, introduzidos em C# 4, aprimoram a conveniência, a flexibilidade e a legibilidade na programação em C#. Além disso, esses recursos facilitam bastante o acesso a interfaces COM, como as APIs de Automação do Microsoft Office.

        //No exemplo a seguir, o método ConvertToTable tem 16 parâmetros que representam as características de uma tabela, como o número de colunas e linhas, formatação, bordas, fontes e cores.Todos os 16 parâmetros são opcionais, pois na maioria das vezes você não quiser especificar valores específicos para todos eles. No entanto, sem argumentos nomeados e opcionais, um valor ou um valor de espaço reservado precisa ser fornecido para cada parâmetro. Com argumentos nomeados e opcionais, você especifica valores apenas para os parâmetros que são necessários para seu projeto.

        //Você deve ter o Microsoft Office Word instalado em seu computador para concluir esses procedimentos.

        //Observação

        //Seu computador pode mostrar diferentes nomes ou locais para alguns dos elementos de interface do usuário do Visual Studio nas instruções a seguir.A edição do Visual Studio que você possui e as configurações que você usa determinam esses elementos.Para obter mais informações, consulte Personalizando o IDE.
        //Para criar um novo aplicativo de console
        //Inicie o Visual Studio.

        //No menu Arquivo, aponte para Novo e clique em Projeto.

        //No painel Templates Categories (Categorias de Modelos), expanda Visual C# e clique em Windows.

        //Observe a parte superior do painel Modelos para se certificar de que.NET Framework 4 é exibido na caixa Estrutura de Destino.

        //No painel Modelos, clique em Aplicativo de Console.

        //Digite um nome para o projeto no campo Nome.

        //Clique em OK.

        //O novo projeto aparece no Gerenciador de Soluções.

        //Para adicionar uma referência
        //No Gerenciador de Soluções, clique com o botão direito do mouse no nome do projeto e, em seguida, clique em Adicionar Referência. A caixa de diálogo Adicionar Referência é exibida.


        //Na página .NET, selecione Microsoft.Office.Interop.Word na lista Nome do Componente.

        //Clique em OK.

        //Para adicionar as diretivas using necessárias
        //No Gerenciador de Soluções, clique com o botão direito do mouse no arquivo Program.cs e, em seguida, clique em Exibir Código.

        //Adicione as seguintes diretivas using na parte superior do arquivo de código.

        //C#

        //Copiar
        //using Word = Microsoft.Office.Interop.Word;
        //Para exibir texto em um documento do Word
        //Na classe Program em Program.cs, adicione o seguinte método para criar um aplicativo do Word e um documento do Word.O método Add tem quatro parâmetros opcionais.Este exemplo usa os valores padrão. Portanto, nenhum argumento é necessário na instrução de chamada.

        //C#

        //Copiar
        //static void DisplayInWord()
        //{
        //var wordApp = new Word.Application();
        //wordApp.Visible = true;
        //// docs is a collection of all the Document objects currently 
        //// open in Word.
        //Word.Documents docs = wordApp.Documents;

        //// Add a document to the collection and name it doc. 
        //Word.Document doc = docs.Add();
        //}
        //Adicione o código a seguir ao final do método para definir onde exibir o texto no documento e o texto a ser exibido.

        //C#

        //Copiar
        //// Define a range, a contiguous area in the document, by specifying
        //// a starting and ending character position. Currently, the document
        //// is empty.
        //Word.Range range = doc.Range(0, 0);

        //// Use the InsertAfter method to insert a string at the end of the
        //// current range.
        //range.InsertAfter("Testing, testing, testing. . .");
        //Para executar o aplicativo
        //Adicione a seguinte instrução a Main.

        //C#

        //Copiar
        //DisplayInWord();
        //Pressione CTRL+F5 para executar o projeto.É exibido um documento do Word contendo o texto especificado.

        //Para alterar o texto para uma tabela
        //Use o método ConvertToTable para colocar o texto em uma tabela.O método tem 16 parâmetros opcionais. O IntelliSense coloca os parâmetros opcionais entre colchetes, como mostrado na ilustração a seguir.


        //Lista de parâmetros do método ConvertToTable.
        //Parâmetros de ConvertToTable

        //Os argumentos nomeados e opcionais permitem que você especifique valores apenas para os parâmetros que deseja alterar. Adicione o seguinte código ao final do método DisplayInWord para criar uma tabela simples.O argumento especifica que as vírgulas na cadeia de caracteres de texto em range separam as células da tabela.

        //C#

        //Copiar
        //// Convert to a simple table. The table will have a single row with
        //// three columns.
        //range.ConvertToTable(Separator: ",");
        //Em versões anteriores do C#, a chamada para ConvertToTable requer um argumento de referência para cada parâmetro, conforme mostrado no código a seguir.

        //C#

        //Copiar
        //// Call to ConvertToTable in Visual C# 2008 or earlier. This code
        //// is not part of the solution.
        //var missing = Type.Missing;
        //object separator = ",";
        //range.ConvertToTable(ref separator, ref missing, ref missing,
        //ref missing, ref missing, ref missing, ref missing,
        //ref missing, ref missing, ref missing, ref missing,
        //ref missing, ref missing, ref missing, ref missing,
        //ref missing);
        //Pressione CTRL+F5 para executar o projeto.

        //Para fazer experiências com outros parâmetros
        //Para alterar a tabela para que ela tenha uma coluna e três linhas, substitua a última linha em DisplayInWord pela instrução a seguir e digite CTRL+F5.

        //C#

        //Copiar
        //range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1);
        //Para especificar um formato predefinido para a tabela, substitua a última linha em DisplayInWord pela a instrução a seguir e digite CTRL+F5.O formato pode ser qualquer uma das constantes WdTableFormat.

        //C#

        //Copiar
        //range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1,
        //Format: Word.WdTableFormat.wdTableFormatElegant);
        //Exemplo
        //O código a seguir inclui o exemplo completo.

        //C#

        //Copiar
        //using System;
        //using System.Collections.Generic;
        //using System.Linq;
        //using System.Text;
        //using Word = Microsoft.Office.Interop.Word;


        //namespace OfficeHowTo
        //{
        //class WordProgram
        //{
        //    static void Main(string[] args)
        //    {
        //        DisplayInWord();
        //    }

        //    static void DisplayInWord()
        //    {
        //        var wordApp = new Word.Application();
        //        wordApp.Visible = true;
        //        // docs is a collection of all the Document objects currently 
        //        // open in Word.
        //        Word.Documents docs = wordApp.Documents;

        //        // Add a document to the collection and name it doc. 
        //        Word.Document doc = docs.Add();

        //        // Define a range, a contiguous area in the document, by specifying
        //        // a starting and ending character position. Currently, the document
        //        // is empty.
        //        Word.Range range = doc.Range(0, 0);

        //        // Use the InsertAfter method to insert a string at the end of the
        //        // current range.
        //        range.InsertAfter("Testing, testing, testing. . .");

        //        // You can comment out any or all of the following statements to
        //        // see the effect of each one in the Word document.

        //        // Next, use the ConvertToTable method to put the text into a table. 
        //        // The method has 16 optional parameters. You only have to specify
        //        // values for those you want to change.

        //        // Convert to a simple table. The table will have a single row with
        //        // three columns.
        //        range.ConvertToTable(Separator: ",");

        //        // Change to a single column with three rows..
        //        range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1);

        //        // Format the table.
        //        range.ConvertToTable(Separator: ",", AutoFit: true, NumColumns: 1,
        //            Format: Word.WdTableFormat.wdTableFormatElegant);
        //    }
        //}
        //}
}
}
