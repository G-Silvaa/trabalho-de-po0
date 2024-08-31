using System;

namespace Entities
{
    public class Pessoa
    {
        private string nome;
        private string telefone;
        private string email;

        public string Nome
        {
            get { return nome; }
            set
            {
                CadastroValidator validator = new CadastroValidator();
                if (validator.ValidarNome(value))
                {
                    nome = value;
                }
            }
        }

        public string Telefone
        {
            get { return telefone; }
            set
            {
                CadastroValidator validator = new CadastroValidator();
                if (validator.VerificarTelefone(value))
                {
                    telefone = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                CadastroValidator validator = new CadastroValidator();
                if (validator.VerificarEmail(value))
                {
                    email = value;
                }
            }
        }

        public Pessoa(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public virtual void AgendarVacinação(DateTime data)
        {
            Console.WriteLine("Agendamento de vacinação para " + Nome + " na data " + data);
        }

        public virtual void Vacinar()
        {
            Console.WriteLine(Nome + " foi vacinado.");
        }
    }
}