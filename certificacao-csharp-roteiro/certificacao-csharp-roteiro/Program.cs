using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Program
    {
        static IList<MenuItem> menuItems;
        static void Main(string[] args)
        {
            IAulaItem itemSelecionado;
            menuItems = GetMenuItems();

            while (true)
            {
                ImprimirMenuItems(menuItems);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int valorOpcao);

                if (valorOpcao == 0)
                {
                    break;
                }
                itemSelecionado = Executar(valorOpcao);
                Console.ReadKey();
            }
        }

        private static IAulaItem Executar(int valorOpcao)
        {
            IAulaItem itemSelecionado;
            MenuItem menuItem = menuItems[valorOpcao - 1];
            Type tipoClasse = menuItem.TipoClasse;
            itemSelecionado = (IAulaItem)Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            itemSelecionado.Executar();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
            return itemSelecionado;
        }

        private static void ImprimirMenuItems(IList<MenuItem> menuItems)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Titulo);
            }
        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem("Tipos de Valor", typeof(TiposDeValor)),
                new MenuItem("Tipos Inteiros", typeof(TiposInteiros)),
                new MenuItem("Ponto Flututante", typeof(PontoFlututante)),
                new MenuItem("Decimal", typeof(Decimal)),
                new MenuItem("Booleanos", typeof(Booleanos)),
                new MenuItem("Estruturas", typeof(Estruturas)),
                new MenuItem("Enumeracoes", typeof(Enumeracoes)),
                new MenuItem("Tipos de Refêrencia", typeof(TiposDeReferencia)),
                new MenuItem("Classes", typeof(Classes)),
                new MenuItem("Interfaces", typeof(Interfaces)),
                new MenuItem("Delegates", typeof(Delegates)),               
                new MenuItem("Dinâmicos", typeof(Dinamicos)),
                new MenuItem("Objetos", typeof(Objetos)),
                new MenuItem("Strings", typeof(Strings)),
                new MenuItem("Metodos", typeof(Metodos)),
                new MenuItem("Parâmetros Opcionais", typeof(ParametrosOpcionais))
            };
        }
    }

    class MenuItem
    {
        public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }

        public string Titulo { get; set; }
        public Type TipoClasse { get; set; }
    }
}
