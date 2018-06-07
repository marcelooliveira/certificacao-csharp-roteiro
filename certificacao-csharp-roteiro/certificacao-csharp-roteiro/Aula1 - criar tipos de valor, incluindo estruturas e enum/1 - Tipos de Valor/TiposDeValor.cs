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
            //int numeroDeAlunos;
            //Console.WriteLine(numeroDeAlunos);
            ////Error CS0165  Use of unassigned local variable 'numeroDeAlunos'

            char resposta = 'S';// System.Char

            byte nivelDeAzul = 0xFF; // == System.Byte 
            int populacao = 1500; // System.Int32 
            short passageirosVoo = 230; // System.Int16 
            long populacaoDoBrasil = 207_660_929; // System.Int64 

            sbyte nivelDeBrilho = 127; // System.Sbyte 
            uint estoque = 1500; // System.UInt32 
            ushort passageirosNavio = 230; // System.UInt16 
            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64 

            bool fumante = false; // System.Boolean booleano
            decimal salario = 5000m; // System.Decimal 
            double massaDaTerra = 5.9736e24; // System.Double
            float numeroPI = 3.14159f; // System.Single

            DiaDaSemana quarta = (DiaDaSemana)2; //Quarta-feira (struct)

            Posicao posicao = new Posicao(13.4, 35.8); //Latitude, Longitude (enumeração)

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"fumante: {fumante}");

            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
            Console.WriteLine($"salario: {salario}");
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");
            Console.WriteLine($"numeroPI: {numeroPI}");

            Console.WriteLine($"quarta: {quarta}");

            Console.WriteLine($"posicao: {posicao}");
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
