using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PropriedadesIndexadas
    {
        //As propriedades indexadas melhoram a maneira na qual as propriedades COM que têm parâmetros são consumidas na programação em C#. As propriedades indexadas trabalham juntamente com outras funcionalidades no Visual C#, como argumentos nomeados e opcionais, um novo tipo (dinâmico) e informações de tipo inseridas para melhorar a programação do Microsoft Office.

        //Nas versões anteriores do C#, os métodos são acessíveis como propriedades apenas se o método get não tem parâmetros e o método set tem apenas um parâmetro de valor. No entanto, nem todas as propriedades COM atendem a essas restrições. Por exemplo, a propriedade Range do Excel tem um acessador get que requer um parâmetro para o nome do intervalo. No passado, como não era possível acessar a propriedade Range diretamente, era necessário usar o método get_Range em vez disso, conforme mostrado no exemplo a seguir.

        //C#

        //Copiar
        //// Visual C# 2008 and earlier.
        //var excelApp = new Excel.Application();
        //// . . .
        //Excel.Range targetRange = excelApp.get_Range("A1", Type.Missing);
        //Em vez disso, as propriedades indexadas permitem escrever o seguinte:

        //C#

        //Copiar
        //// Visual C# 2010.
        //var excelApp = new Excel.Application();
        //// . . .
        //Excel.Range targetRange = excelApp.Range["A1"];
        //Observação

        //O exemplo anterior também usa o recurso argumentos opcionais, que permite que você omita Type.Missing.

        //Da mesma forma, para definir o valor da propriedade Value de um objeto Range no Visual C# 2008 e versões anteriores, dois argumentos são necessários. Um fornece um argumento para um parâmetro opcional que especifica o tipo do valor de intervalo. O outro fornece o valor para a propriedade Value. Os exemplos a seguir ilustram essas técnicas. Ambos definem o valor da célula A1 como Name.
        //C#

        //Copiar
        //// Visual C# 2008.
        //targetRange.set_Value(Type.Missing, "Name");
        //// Or
        //targetRange.Value2 = "Name";
        //Em vez disso, as propriedades indexadas permitem escrever o código a seguir.

        //C#

        //Copiar
        //// Visual C# 2010.
        //targetRange.Value = "Name";
        //Não é possível criar propriedades indexadas de sua preferência.O recurso dá suporte apenas ao consumo de propriedades indexadas existentes.

        //Exemplo
        //O código a seguir mostra um exemplo completo.Para obter mais informações sobre como configurar um projeto que acessa a API do Office, consulte Como acessar objetos de interoperabilidade do Office usando recursos do Visual C#.

        //C#

        //Copiar
        //// You must add a reference to Microsoft.Office.Interop.Excel to run 
        //// this example.
        //using System;
        //using Excel = Microsoft.Office.Interop.Excel;

        //namespace IndexedProperties
        //{
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        CSharp2010();
        //        //CSharp2008();
        //    }

        //    static void CSharp2010()
        //    {
        //        var excelApp = new Excel.Application();
        //        excelApp.Workbooks.Add();
        //        excelApp.Visible = true;

        //        Excel.Range targetRange = excelApp.Range["A1"];
        //        targetRange.Value = "Name";
        //    }

        //    static void CSharp2008()
        //    {
        //        var excelApp = new Excel.Application();
        //        excelApp.Workbooks.Add(Type.Missing);
        //        excelApp.Visible = true;

        //        Excel.Range targetRange = excelApp.get_Range("A1", Type.Missing);
        //        targetRange.set_Value(Type.Missing, "Name");
        //        // Or
        //        //targetRange.Value2 = "Name";

        //    }
        //}
        //}
}
}
