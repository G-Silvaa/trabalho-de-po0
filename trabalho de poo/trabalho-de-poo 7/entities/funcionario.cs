using System;
using System.Collections.Generic;

namespace Entities
{
    public class Funcionario : Pessoa
    {
        public string Matricula { get; set; }
        public string CnpjPrestadora { get; set; }
        private List<Cidadao> cidadaosCadastrados;
        private List<DateTime> agendamentos;

        public Funcionario(string nome, string matricula, string cnpjPrestadora, string telefone, string email)
            : base(nome, telefone, email)
        {
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
            cidadaosCadastrados = new List<Cidadao>();
            agendamentos = new List<DateTime>();
        }

        public void CadastrarCidadao(Cidadao cidadao)
        {
            if (cidadaosCadastrados.Exists(c => c.CPF == cidadao.CPF))
            {
                Console.WriteLine("Cidadão já cadastrado!");
                return;
            }
            cidadaosCadastrados.Add(cidadao);
        }

        public bool LoginCidadao(string cpf)
        {
            return cidadaosCadastrados.Exists(c => c.CPF == cpf);
        }

        public void AdicionarAgendamento(DateTime data)
        {
            CadastroValidator validator = new CadastroValidator();
            if (validator.ValidarData(data.ToString("yyyy-MM-dd"), true))
            {
                agendamentos.Add(data);
                Console.WriteLine($"Agendamento para vacinação adicionado: {data}");
            }
        }

        public override void AgendarVacinação(DateTime data)
        {
            base.AgendarVacinação(data);
            Console.WriteLine("Funcionario " + Nome + " agendou vacinação para " + data);
        }

        public override void Vacinar()
        {
            base.Vacinar();
            Console.WriteLine("Funcionario " + Nome + " vacinou um cidadão.");
        }
    }
}