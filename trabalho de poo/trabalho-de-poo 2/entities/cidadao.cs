namespace Entities {
    public class Cidadao {
        private string cpf;
        public string CPF {
            get { return cpf; }
            private set { cpf = value; }
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Vacinado { get; set; }

        public Cidadao(string cpf, string nome, int idade, bool vacinado) {
            CPF = cpf;
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
        }

        public bool AlterarCPF(string novoCpf, string senhaAdmin) {
            if (senhaAdmin == "admin123") {
                CPF = novoCpf;
                return true;
            }
            return false;
        }
    }
}