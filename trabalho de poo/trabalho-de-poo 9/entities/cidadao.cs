using System;
using Validators;
using Interfaces;

namespace Entities
{
    public class Cidadao : Pessoa
    {
        private string cpf;
        public int Idade { get; set; }
        public bool Vacinado { get; set; }

        public string CPF
        {
            get { return cpf; }
            set
            {
                CadastroValidator validator = new CadastroValidator();
                if (validator.ValidarCPF(value))
                {
                    cpf = value;
                }
            }
        }

        public Cidadao(string cpf, string nome, int idade, bool vacinado, string telefone, string email)
            : base(nome, telefone, email)
        {
            CPF = cpf;
            Idade = idade;
            Vacinado = vacinado;
        }
    }
}