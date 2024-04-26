using System;
using System.Collections.Generic;

namespace estudos_c_.models
{
    public class Cliente
    {
        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public string Nome { get; set; }
        public string Email { get; set; }

        public List<Cliente> ListaDePessoas = new List<Cliente>();

        public void AdicionarPessoa(string nome, string email)
        {

            if(nome != null && email != null)
            {
            Cliente pessoa = new Cliente(nome, email);
            ListaDePessoas.Add(pessoa);
            }
            else 
            {
                Console.WriteLine("O email e o nome não podem ser nulos.");
            }
        }

        public void RemoverPessoa(string nome, string email)
        {

            if (nome != null && email != null)
            {
                Cliente pessoaParaRemover = ListaDePessoas.Find(p => p.Nome == nome && p.Email == email);

                if (pessoaParaRemover != null)
                {
                    ListaDePessoas.Remove(pessoaParaRemover);
                    Console.WriteLine($"Pessoa '{nome}' e email '{email}' removida com sucesso.");
                }
                else
                {
                    Console.WriteLine($"Pessoa '{nome}' não encontrada na lista.");
                }
            } else
            {
                Console.WriteLine("o nome e o email não podem ser nulos.");
            }

        }

        public void ListarPessoa()
        {
            
            if (ListaDePessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
                return;
            }

            Console.WriteLine("Lista de Pessoas:");
            foreach (var pessoa in ListaDePessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Email: {pessoa.Email}");
            }
        }

        public void EditarPessoa(string Nome, string Email)
        {
            

                Console.WriteLine("digite o novo nome para a pessoa:");
                string novoNome = Console.ReadLine();
                this.Nome = novoNome;

                Console.WriteLine("caso deseje, sobrescreva o email pelo mais recente");
                string novoEmail = Console.ReadLine();
                this.Email = novoEmail;

                Console.WriteLine("nome e email editados com sucesso!");

            return ;
        }

    }
}
