using estudos_c_.models;

BancoDeDados BDInicial = new BancoDeDados();

Cliente Pessoa = new Cliente();
//teste
// Cliente C1 = new Cliente();

// BDInicial.InicializarSistema();


// C1.ExibirInformacoes();

// Console.WriteLine("digite o seu nome:");
// C1.Nome = Console.ReadLine();

// Console.WriteLine("agora, digite a sua idade:");
// C1.Idade = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Por ultimo digite seu email");
// C1.Email = Console.ReadLine();

// Console.WriteLine($"Usuário {C1.Nome}, de idade {C1.Idade} e email {C1.Email}");

int i = 0;
while(i == 0)
{
    Console.WriteLine("bem vindo ao sistema de cadastro!\n selecione uma das opções: \n1- cadastrar pessoa\n2- remover pessoa\n3- listar pessoa\n4- encerrar atendimento");
    int menu = Convert.ToInt32(Console.ReadLine());

    switch(menu)
    {
        case 1: 
        Console.WriteLine("cadastrar pessoa");
        Pessoa.AdicionarPessoa();
        
        break;

        case 2: 
        Console.WriteLine("remover pessoa");
        break;

        case 3: 
        Console.WriteLine("Listar pessoa");
        break;

        case 4: 
        Console.WriteLine("encerrar programa");
        i = 1;
        break;

        default: 
        Console.WriteLine("comando inválido. Digite novamente");
        break;
    }
}
