using System;
using System.Collections.Generic;

namespace Entities {
    public class Funcionario {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string CnpjPrestadora { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        private List<Cidadao> cidadaosCadastrados;
        private List<DateTime> agendamentos;

        public Funcionario(string nome, string matricula, string cnpjPrestadora) {
            Nome = nome;
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
            cidadaosCadastrados = new List<Cidadao>();
            agendamentos = new List<DateTime>();
        }

        public Funcionario(string nome, string matricula, string cnpjPrestadora, string telefone, string email) {
            Nome = nome;
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
            Telefone = telefone;
            Email = email;
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
    }
}