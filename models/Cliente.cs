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

        private List<Cliente> ListaDePessoas = new List<Cliente>();

        public void AdicionarPessoa(string nome, string email)
        {
            Cliente pessoa = new Cliente(nome, email);
            ListaDePessoas.Add(pessoa);
        }

        public void RemoverPessoa(string nome, string email)
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

    }
}
