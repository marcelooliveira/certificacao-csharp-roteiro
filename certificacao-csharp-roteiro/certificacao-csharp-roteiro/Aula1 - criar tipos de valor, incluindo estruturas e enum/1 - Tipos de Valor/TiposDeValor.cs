using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            byte nivelDeAzul = 0xFF; // == System.Byte 
            char resposta = 'S';// System.Char
            int populacao = 1500; // System.Int32 
            short passageirosVoo = 230; // System.Int16 
            long populacaoDoBrasil = 207_660_929; // System.Int64 
            bool fumante = false; // System.Boolean booleano

            sbyte nivelDeBrilho = 127; // System.Sbyte 
            uint varUint = 1500; // System.UInt32 
            ushort passageirosNavio = 230; // System.UInt16 
            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64 
            decimal salario = 5000m; // System.Decimal 
            double massaDaTerra = 5.9736e24; // System.Double
            float numeroPI = 3.14159f; // System.Single

            DiaDaSemana quarta = (DiaDaSemana)2;

            Posicao posicao = new Posicao(13.4, 35.8);

            Console.WriteLine(nivelDeAzul);
            Console.WriteLine(resposta);
            Console.WriteLine(populacao);
            Console.WriteLine(passageirosVoo);
            Console.WriteLine(populacaoDoBrasil);
            Console.WriteLine(fumante);

            Console.WriteLine(nivelDeBrilho);
            Console.WriteLine(varUint);
            Console.WriteLine(passageirosNavio);
            Console.WriteLine(populacaoDoMundo);
            Console.WriteLine(salario);
            Console.WriteLine(massaDaTerra);
            Console.WriteLine(numeroPI);

            Console.WriteLine(quarta);

            Console.WriteLine(posicao);
        }
    }

    enum DiaDaSemana { SEG, TER, QUA, QUI, SEX, SAB };

    struct Posicao
    {
        double Latitude;
        double Longitude;

        public Posicao(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} ; Longitude: {Longitude}";
        }
    }
}
