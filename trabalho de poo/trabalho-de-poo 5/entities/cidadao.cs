using System;

namespace Entities {
    public class Cidadao : Pessoa {
        public string CPF { get; set; }
        public int Idade { get; set; }
        public bool Vacinado { get; set; }

        public Cidadao(string cpf, string nome, int idade, bool vacinado, string telefone, string email)
            : base(nome, telefone, email) {
            CPF = cpf;
            Idade = idade;
            Vacinado = vacinado;
        }
    }
}