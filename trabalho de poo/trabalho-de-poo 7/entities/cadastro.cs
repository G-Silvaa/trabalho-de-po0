using System;
using System.Collections.Generic;

namespace Entities {
    public class CadastroService {
        private List<Funcionario> funcionarios;
        private List<Cidadao> cidadaos;

        public CadastroService() {
            funcionarios = new List<Funcionario>();
            cidadaos = new List<Cidadao>();
        }

        public void AdicionarFuncionario(Funcionario funcionario) {
            if (funcionarios.Exists(f => f.Matricula == funcionario.Matricula)) {
                Console.WriteLine("Funcionário já cadastrado!");
                return;
            }
            funcionarios.Add(funcionario);
        }

        public Funcionario BuscarFuncionario(string matricula) {
            return funcionarios.Find(f => f.Matricula == matricula);
        }

        public void AdicionarCidadao(Cidadao cidadao) {
            if (cidadaos.Exists(c => c.CPF == cidadao.CPF)) {
                Console.WriteLine("Cidadão já cadastrado!");
                return;
            }
            cidadaos.Add(cidadao);
        }

        public Cidadao BuscarCidadao(string cpf) {
            return cidadaos.Find(c => c.CPF == cpf);
        }
    }
}