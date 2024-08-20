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

        public virtual void AgendarVacinação(DateTime data) {
            Console.WriteLine("Agendamento de vacinação para " + Nome + " na data " + data);
        }

        public virtual void Vacinar() {
            Console.WriteLine(Nome + " foi vacinado.");
        }
    }

    public class cidadao : Pessoa {
        public string CPF { get; set; }
        public int Idade { get; set; }
        public bool Vacinado { get; set; }

        public cidadao(string cpf, string nome, int idade, bool vacinado, string telefone, string email)
            : base(nome, telefone, email) {
            CPF = cpf;
            Idade = idade;
            Vacinado = vacinado;
        }

        public override void AgendarVacinação(DateTime data) {
            base.AgendarVacinação(data);
            Console.WriteLine("Cidadao " + Nome + " agendou vacinação para " + data);
        }

        public override void Vacinar() {
            base.Vacinar();
            Vacinado = true;
            Console.WriteLine("Cidadao " + Nome + " foi vacinado.");
        }
    }

    public class funcionario : Pessoa {
        public string Matricula { get; set; }
        public string CnpjPrestadora { get; set; }
        private List<Cidadao> cidadaosCadastrados;
        private List<DateTime> agendamentos;

        public funcionario(string nome, string matricula, string cnpjPrestadora, string telefone, string email)
            : base(nome, telefone, email) {
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
            cidadaosCadastrados = new List<Cidadao>();
            agendamentos = new List<DateTime>();
        }

        public void CadastrarCidadao(Cidadao cidadao) {
            if (cidadaosCadastrados.Exists(c => c.CPF == cidadao.CPF)) {
                Console.WriteLine("Cidadão já cadastrado!");
                return;
            }
            cidadaosCadastrados.Add(cidadao);
        }

        public bool LoginCidadao(string cpf) {
            return cidadaosCadastrados.Exists(c => c.CPF == cpf);
        }

        public void AdicionarAgendamento(DateTime data) {
            agendamentos.Add(data);
            Console.WriteLine($"Agendamento para vacinação adicionado: {data}");
        }

        public override void AgendarVacinação(DateTime data) {
            base.AgendarVacinação(data);
            Console.WriteLine("Funcionario " + Nome + " agendou vacinação para " + data);
        }

        public override void Vacinar() {
            base.Vacinar();
            Console.WriteLine("Funcionario " + Nome + " vacinou um cidadão.");
        }
    }
}