using estudos_c_.models;

BancoDeDados BDInicial = new BancoDeDados();
Cliente Interacao = new Cliente("Pedro Augusto", "PedrinhoEmbaixador2024@gmail.com");

BDInicial.InicializarSistema();

int i = 0;
while (i == 0)
{
    Console.WriteLine("\n\nBem-vindo ao sistema de cadastro!\n\n\n\nSelecione uma das opções: \n1- Cadastrar pessoa\n2- Remover pessoa\n3- Listar pessoas\n4- Encerrar atendimento");
    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:

            string Nome;
            string Email;
            Console.WriteLine("Cadastrar pessoa");
            Console.WriteLine("Digite o nome:");
            Nome = Console.ReadLine();

            Console.WriteLine($"Agora digite o email de {Nome}");
            Email = Console.ReadLine();

            Interacao.AdicionarPessoa(Nome, Email);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
            break;

        case 2:
            Console.WriteLine("Remover pessoa");
            Console.WriteLine("Digite o nome da pessoa para remoção:");
            Nome = Console.ReadLine();
            Console.WriteLine("agora digite o email que a pessoa esta vinculada:");
            Email = Console.ReadLine();

            if (Nome != null && Email != null)
            {
                Interacao.RemoverPessoa(Nome, Email);
            }
            break;

        case 3:
            
            Console.WriteLine("Listar pessoas:");
            Interacao.ListarPessoa();
            break;

        case 4:
            Console.WriteLine("Encerrar programa");
            i = 1;
            break;

        default:
            Console.WriteLine("Comando inválido. Digite novamente");
            break;

    }
}
