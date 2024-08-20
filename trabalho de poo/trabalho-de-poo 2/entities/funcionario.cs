using System;
using System.Collections.Generic;

namespace Entities {
    public class Funcionario {
        private static int ultimoIdentificador = 0;
        public int Identificador { get; private set; }
        public string Nome { get; set; }
        private string matricula;
        public string Matricula {
            get { return matricula; }
            private set { matricula = value; }
        }
        public string CnpjPrestadora { get; set; }

        private List<Cidadao> cidadaosCadastrados;

        public Funcionario(string nome, string matricula, string cnpjPrestadora) {
            Identificador = ++ultimoIdentificador;
            Nome = nome;
            Matricula = matricula;
            CnpjPrestadora = cnpjPrestadora;
            cidadaosCadastrados = new List<Cidadao>();
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

        public bool AlterarMatricula(string novaMatricula, string senhaAdmin) {
            if (senhaAdmin == "admin123") {
                Matricula = novaMatricula;
                return true;
            }
            return false;
        }
    }
}