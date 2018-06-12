using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            //A instância cliente1 não passa um argumento para o parâmetro opcional
            //do construtor
            ClienteOpcional cliente1 = new ClienteOpcional();
            cliente1.FazerPedido(1, "Residencial", 1);
            cliente1.FazerPedido(2, "Comercial");
            cliente1.FazerPedido(3);

            //A instância cliente2 fornece um argumento para o parâmetro opcional
            //do construtor
            ClienteOpcional cliente2 = new ClienteOpcional("Lucas Skywalker");
            cliente2.FazerPedido(1, "Residencial", 1);
            cliente2.FazerPedido(2, "Comercial");
            cliente2.FazerPedido(3);

            // As instruções a seguir produzem erros de compilação.

            // Um argumento tem que ser fornecido para o primeiro parâmetro, e ele
            // precisa ser um inteiro.
            //cliente1.FazerPedido("Residencial", 1);
            //cliente1.FazerPedido();

            // Você não pode deixar um "buraco" nos argumentos
            //cliente1.FazerPedido(3, , 4);
            //cliente1.FazerPedido(3, 4);

            // Você pode usar um argumento nomeado para fazer 
            // a instrução anterior funcionar.
            cliente1.FazerPedido(3, quantidade: 4);
        }
    }

    class ClienteOpcional
    {
        private readonly string nome;
        public ClienteOpcional(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        //O primeiro parâmetro é obrigatório e não tem nenhum valor padrão associado a ele.
        //Portanto, ele não é opcional. Tanto endereco quanto quantidade tem valores padrão
        //associados. Eles são opcionais.
        public void FazerPedido(int produtoId, string endereco = "Residencial",
            int quantidade = 10)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
