using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            Console.WriteLine($"retangulo.Area: {retangulo.Area()}");

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine("Retangulo outroRetangulo = new Retangulo(10, 10);");

            Console.WriteLine($"retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura): " +
                $"{retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura)}");

            outroRetangulo = new Retangulo(5, 6);
            Console.WriteLine("Retangulo outroRetangulo = new Retangulo(5, 6);");

            Console.WriteLine($"retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura): " +
                $"{retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura)}");
        }
    }

    class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");

            var area = Altura * Largura;
            Console.WriteLine($"area: {area}");

            Console.WriteLine($"Area(): {Area()}");
        }

        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area()
        {
            return Altura * Largura;
        }
        
        public bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }

        public bool Semelhante(Retangulo outroRetangulo)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetangulo.Largura / outroRetangulo.Altura));
        }
    }
}
