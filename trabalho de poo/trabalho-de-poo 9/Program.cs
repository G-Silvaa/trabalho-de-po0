using System;
using Entities;
using Validators;
using Interfaces;

class Program
{
    static void Main(string[] args)
    {
        CadastroService cadastroService = new CadastroService();
        CadastroValidator validator = new CadastroValidator();

        try
        {
            Console.WriteLine("Cadastro de Funcionário:");
            Console.Write("Nome: ");
            string? nomeFuncionario = Console.ReadLine();
            if (nomeFuncionario != null) validator.ValidarNome(nomeFuncionario);
            Console.Write("Matrícula: ");
            string? matriculaFuncionario = Console.ReadLine();
            Console.Write("CNPJ da Prestadora de Serviço: ");
            string? cnpjPrestadora = Console.ReadLine();
            Console.Write("Telefone: ");
            string? telefoneFuncionario = Console.ReadLine();
            if (telefoneFuncionario != null) validator.VerificarTelefone(telefoneFuncionario);
            Console.Write("Email: ");
            string? emailFuncionario = Console.ReadLine();
            if (emailFuncionario != null) validator.VerificarEmail(emailFuncionario);

            if (nomeFuncionario != null && matriculaFuncionario != null && cnpjPrestadora != null && telefoneFuncionario != null && emailFuncionario != null)
            {
                Funcionario funcionario = new Funcionario(nomeFuncionario, matriculaFuncionario, cnpjPrestadora, telefoneFuncionario, emailFuncionario);
                ((ICadastro<Funcionario>)cadastroService).Adicionar(funcionario);

                Console.WriteLine("\nCadastro de Cidadão:");
                Console.Write("CPF: ");
                string? cpfCidadao = Console.ReadLine();
                if (cpfCidadao != null) validator.VerificarCPF(cpfCidadao);
                Console.Write("Nome: ");
                string? nomeCidadao = Console.ReadLine();
                if (nomeCidadao != null) validator.ValidarNome(nomeCidadao);
                Console.Write("Idade: ");
                string? idadeCidadaoStr = Console.ReadLine();
                int idadeCidadao = idadeCidadaoStr != null ? int.Parse(idadeCidadaoStr) : 0;
                validator.VerificarIdade(idadeCidadao);
                Console.Write("Vacinado (true/false): ");
                string? vacinadoCidadaoStr = Console.ReadLine();
                bool vacinadoCidadao = vacinadoCidadaoStr != null && bool.Parse(vacinadoCidadaoStr);
                Console.Write("Telefone: ");
                string? telefoneCidadao = Console.ReadLine();
                if (telefoneCidadao != null) validator.VerificarTelefone(telefoneCidadao);
                Console.Write("Email: ");
                string? emailCidadao = Console.ReadLine();
                if (emailCidadao != null) validator.VerificarEmail(emailCidadao);

                if (cpfCidadao != null && nomeCidadao != null && telefoneCidadao != null && emailCidadao != null)
                {
                    Cidadao cidadao = new Cidadao(cpfCidadao, nomeCidadao, idadeCidadao, vacinadoCidadao, telefoneCidadao, emailCidadao);
                    ((ICadastro<Cidadao>)cadastroService).Adicionar(cidadao);
                    funcionario.CadastrarCidadao(cidadao);

                    Console.WriteLine("\nLogin de Cidadão:");
                    Console.Write("CPF: ");
                    string? cpfLogin = Console.ReadLine();

                    if (cpfLogin != null)
                    {
                        bool loginSucesso = funcionario.LoginCidadao(cpfLogin);
                        if (loginSucesso)
                        {
                            Console.WriteLine("Login bem-sucedido! Cidadão cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("Cidadão não cadastrado.");
                        }
                    }

                    Console.WriteLine("\nAgendamento de Vacinação:");
                    Console.Write("Data (yyyy-MM-dd): ");
                    string? dataAgendamentoStr = Console.ReadLine();
                    if (dataAgendamentoStr != null)
                    {
                        DateTime dataAgendamento = DateTime.Parse(dataAgendamentoStr);
                        funcionario.AdicionarAgendamento(dataAgendamento);
                        funcionario.AgendarVacinação(dataAgendamento);
                    }

                    Console.WriteLine("\nVacinação:");
                    funcionario.Vacinar();
                    cidadao.Vacinar();
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro na validação dos dados: {ex.Message}");
        }
    }
}