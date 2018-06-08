using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            OnibusTurismo onibusTurismo = new OnibusTurismo("Turbo Jet Bus", "Mercedes", 2015, 8);
            Console.WriteLine(onibusTurismo); ;
        }
    }

    public interface IVeiculo
    {
        int Rodas { get; set; }
    }

    public interface IVeiculoMotorizado : IVeiculo
    {
        //métodos
        void Embarcar();
        void Desembarcar();

        //propriedades
        string Nome { get; set; }
        string Fabricante { get; set; }
        int Ano { get; set; }

        //evento
        event EventHandler MotorLigou;
    }

    public interface ITransportePublico
    {
        void CobrarPassagem();
    }

    public class Onibus: IVeiculoMotorizado, ITransportePublico
    {
        public Onibus(string nome, string fabricante, int ano, int rodas)
        {
            Nome = nome;
            Fabricante = fabricante;
            Ano = ano;
            Rodas = rodas;
        }

        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }
        public int Rodas { get; set; }

        public event EventHandler MotorLigou;

        public void CobrarPassagem()
        {
            //código para CobrarPassagem
            throw new NotImplementedException();
        }

        public void Desembarcar()
        {
            //código para Desembarcar
            throw new NotImplementedException();
        }

        public void Embarcar()
        {
            //código para Embarcar
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"nome: {Nome}, fabricante {Fabricante}, ano {Ano}, rodas {Rodas}";
        }
    }

    public class OnibusTurismo : Onibus
    {
        public OnibusTurismo(string nome, string fabricante, int ano, int rodas) : base(nome, fabricante, ano, rodas)
        {
        }
    }
}
