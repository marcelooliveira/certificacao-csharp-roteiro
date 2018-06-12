using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato { Nome = "Pantera" };
            gata.Beber();
            gata.Comer();
            gata.Andar();
        }
    }

    class Animal
    {
        public String Nome { get; set; }

        public void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }

        public void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }

    class Gato : Animal
    {
        // warning: esconde o método Beber() herdado. Utilize new
        public void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }

        public override void Comer() // substitui o método herdado Comer().
        {
            Console.WriteLine("Gato.Comer");
        }

        public new void Andar() // esconde o método Andar() herdado.
        {
            Console.WriteLine("Gato.Andar");
        }
    }
}