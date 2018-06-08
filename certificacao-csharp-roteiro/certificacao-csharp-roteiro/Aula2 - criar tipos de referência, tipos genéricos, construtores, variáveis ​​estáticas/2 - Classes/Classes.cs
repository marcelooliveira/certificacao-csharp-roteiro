using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS(13.78, 29.51);
            ClassePosicaoGPS posicao2 = new ClassePosicaoGPS(40.23, 17.4);
            Console.WriteLine(posicao1);
            Console.WriteLine(posicao2);

            SubclassePosicaoGPS posicao3 = new SubclassePosicaoGPS(13.78, 29.51, new DateTime(2018, 6, 1));
            Console.WriteLine($"SubclassePosicaoGPS posicao3 = new SubclassePosicaoGPS(13.78, 29.51, new DateTime(2018, 6, 1));");
            Console.WriteLine($"posicao3: {posicao3}");

            SubclassePosicaoGPS posicao4; //não inicializada: contém null

            SubclassePosicaoGPS posicao5 = new SubclassePosicaoGPS(13.78, 29.51, new DateTime(2018, 6, 1));

            SubclassePosicaoGPS posicao6 = posicao5;

            Cliente objeto1 = new Cliente("Lucas Skywalker", 22);

            //Cliente objeto2;
            //Console.WriteLine(objeto2.Nome);
        }
    }

    public class ClassePosicaoGPS : IHemisferio
    {
        public double Latitude;
        public double Longitude;

        public ClassePosicaoGPS()
        {

        }

        public ClassePosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return $"Latitude = {Latitude}, Longitude = {Longitude}";
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }
    }

    public class SubclassePosicaoGPS : ClassePosicaoGPS
    {
        public SubclassePosicaoGPS(double latitude, double longitude, DateTime ultimaLeitura)
            : base(latitude, longitude)
        {
            this.UltimaLeitura = ultimaLeitura;
        }

        public DateTime UltimaLeitura { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Última leitura: {UltimaLeitura.ToShortDateString()}";
        }
    }
}
