using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS posicao1 = new PosicaoGPS(13.78, 29.51);
            PosicaoGPS posicao2 = new PosicaoGPS(40.23, 17.4);
            Console.WriteLine(posicao1);
            Console.WriteLine(posicao2);

            PosicaoGPS posicao3;
            posicao3.Latitude = 13.78;
            posicao3.Longitude = 29.51;
            Console.WriteLine($"posicao3 = {posicao3}");

            //PosicaoGPS posicao4;
            //posicao4.Latitude = 13.78;
            //Console.WriteLine($"posicao4 = {posicao4}");
            //Error CS0165  Use of unassigned local variable 'posicao4'

            Console.WriteLine($"posicao1.Latitude = {posicao1.Latitude}");
            Console.WriteLine($"posicao1.Longitude = {posicao1.Longitude}");

            //typeof(PosicaoGPS).BaseType.Name
            //"ValueType"
            //typeof(ValueType).BaseType.Name
            //"Object"
        }
    }

    interface IHemisferio
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IHemisferio
    {
        public double Latitude;
        public double Longitude;

        //public PosicaoGPS()
        //{

        //}
        //Error CS0568  Structs cannot contain explicit parameterless constructors

        public PosicaoGPS(double latitude, double longitude)
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
}
