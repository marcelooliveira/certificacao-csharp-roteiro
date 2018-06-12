using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            Fisica fisica = new Fisica();

            int lado = 3;
            Console.WriteLine($"Volume(lado): {fisica.Volume(lado)}");

            double raio = 2;
            int altura = 10;
            Console.WriteLine($"Volume(raio, altura): {fisica.Volume(raio, altura)}");

            long largura = 5;
            altura = 7;
            int profundidade = 9;
            Console.WriteLine($"Volume(largura, altura, profundidade): {fisica.Volume(largura, altura, profundidade)}");
        }
    }

    class Fisica
    {
        // volume de um cubo
        public int Volume(int lado)
        {
            return lado * lado * lado;
        }

        // volume de um cilindro
        public double Volume(double raio, int altura)
        {
            return Math.PI * raio * raio * (double)altura;
        }

        // volume de um paralelepípedo
        public long Volume(long largura, int altura, int profundidade)
        {
            return largura * altura * profundidade;
        }

    }
}
