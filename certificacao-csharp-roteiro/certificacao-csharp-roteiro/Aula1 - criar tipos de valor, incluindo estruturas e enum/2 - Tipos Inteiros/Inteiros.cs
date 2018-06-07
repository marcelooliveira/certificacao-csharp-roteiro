using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            //Type    Range                               Size
            //======================================================================
            //sbyte  -128 to 127                          Signed 8-bit integer
            //byte    0 to 255                            Unsigned 8-bit integer
            //char    U+0000 to U+ffff                    Unicode 16-bit character
            //short  -32,768 to 32,767                    Signed 16-bit integer
            //ushort  0 to 65,535                         Unsigned 16-bit integer
            //int     -2,147,483,648 to 2,147,483,647     Signed 32-bit integer
            //uint    0 to 4,294,967,295                  Unsigned 32-bit integer
            //long    -9,223,372,036,854,775,808 
            //to 9,223,372,036,854,775,807    Signed 64-bit integer
            //ulong   0 to 18,446,744,073,709,551,615     Unsigned 64-bit integer

            char resposta = 'S';// System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal
            short passageirosVoo = 230; // System.Int16 
            int populacao = 1500; // System.Int32 
            long populacaoDoBrasil = 207_660_929; // +/- 207 milhões  - System.Int64 

            sbyte nivelDeBrilho = 127; // System.Sbyte 
            ushort passageirosNavio = 230; // System.UInt16 
            uint estoque = 1500; // System.UInt32 
            ulong populacaoDoMundo = 7_000_000_000; // 7 bilhões - System.UInt64 

            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");




            //nivelDeAzul = 0xFFFF; // = 65535 em decimal
            //Error CS0031  Constant value '65535' cannot be converted to a 'byte'

            //passageirosVoo = 230000; // System.Int16 
            //Error CS0031  Constant value '230000' cannot be converted to a 'short'

            //populacao = 15000000000; // System.Int32 
            //Error CS0266  Cannot implicitly convert type 'long' to 'int'

            //ushort passageirosNavio = -15; // System.UInt16 
            //Error CS0031  Constant value '-15' cannot be converted to a 'ushort'

            //uint estoque = -2300; // System.UInt32 
            //Error CS0031  Constant value '-2300' cannot be converted to a 'uint'

    }
}
}
