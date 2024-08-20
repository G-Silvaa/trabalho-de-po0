using System;

namespace Entities {
    public class Pessoa {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string telefone, string email) {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}