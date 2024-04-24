using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_c_.models
{
    public class Informacao
    {
        public string PrimeiroCampo { get; set; }
        
        public Informacao(string Primeiro)
        {
            PrimeiroCampo = Primeiro;
            
        }

        private List<Informacao> ListaDePessoas = new List<Informacao>();


        public void AdicionarPessoa()
        {
            Console.WriteLine("Digite o nome do individuo: ");
            string nome  = Console.ReadLine();
            Informacao Pessoa = new Informacao(nome);
            ListaDePessoas.Add(Pessoa);
            
        }

        public void RemoverPessoa()
        {
            Console.WriteLine("Digite o nome do individuo: ");
            string nome  = Console.ReadLine();
            Informacao Pessoa = new Informacao(nome);
            ListaDePessoas.Remove(Pessoa);
            
        }
    }
}