using System;
using System.Collections.Generic;
using Interfaces;

namespace Entities
{
    public class CadastroService : ICadastro<Funcionario>, ICadastro<Cidadao>
    {
        private List<Funcionario> funcionarios;
        private List<Cidadao> cidadaos;

        public CadastroService()
        {
            funcionarios = new List<Funcionario>();
            cidadaos = new List<Cidadao>();
        }

        // Explicit interface implementation for Funcionario
        void ICadastro<Funcionario>.Adicionar(Funcionario funcionario)
        {
            if (funcionarios.Exists(f => f.Matricula == funcionario.Matricula))
            {
                Console.WriteLine("Funcionário já cadastrado!");
                return;
            }
            funcionarios.Add(funcionario);
        }

        Funcionario ICadastro<Funcionario>.Buscar(string matricula)
        {
            return funcionarios.Find(f => f.Matricula == matricula);
        }

        // Explicit interface implementation for Cidadao
        void ICadastro<Cidadao>.Adicionar(Cidadao cidadao)
        {
            if (cidadaos.Exists(c => c.CPF == cidadao.CPF))
            {
                Console.WriteLine("Cidadão já cadastrado!");
                return;
            }
            cidadaos.Add(cidadao);
        }

        Cidadao ICadastro<Cidadao>.Buscar(string cpf)
        {
            return cidadaos.Find(c => c.CPF == cpf);
        }
    }
}