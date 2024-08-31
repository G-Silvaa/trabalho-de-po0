using System;
using Entities;
using Validators;

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
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Matrícula: ");
            string matriculaFuncionario = Console.ReadLine();
            Console.Write("CNPJ da Prestadora de Serviço: ");
            string cnpjPrestadora = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefoneFuncionario = Console.ReadLine();
            validator.VerificarTelefone(telefoneFuncionario);
            Console.Write("Email: ");
            string emailFuncionario = Console.ReadLine();
            validator.VerificarEmail(emailFuncionario);

            Funcionario funcionario = new Funcionario(nomeFuncionario, matriculaFuncionario, cnpjPrestadora, telefoneFuncionario, emailFuncionario);
            cadastroService.AdicionarFuncionario(funcionario);

            Console.WriteLine("\nCadastro de Cidadão:");
            Console.Write("CPF: ");
            string cpfCidadao = Console.ReadLine();
            validator.VerificarCPF(cpfCidadao);
            Console.Write("Nome: ");
            string nomeCidadao = Console.ReadLine();
            Console.Write("Idade: ");
            int idadeCidadao = int.Parse(Console.ReadLine());
            validator.VerificarIdade(idadeCidadao);
            Console.Write("Vacinado (true/false): ");
            bool vacinadoCidadao = bool.Parse(Console.ReadLine());
            Console.Write("Telefone: ");
            string telefoneCidadao = Console.ReadLine();
            validator.VerificarTelefone(telefoneCidadao);
            Console.Write("Email: ");
            string emailCidadao = Console.ReadLine();
            validator.VerificarEmail(emailCidadao);

            Cidadao cidadao = new Cidadao(cpfCidadao, nomeCidadao, idadeCidadao, vacinadoCidadao, telefoneCidadao, emailCidadao);
            cadastroService.AdicionarCidadao(cidadao);
            funcionario.CadastrarCidadao(cidadao);

            Console.WriteLine("\nLogin de Cidadão:");
            Console.Write("CPF: ");
            string cpfLogin = Console.ReadLine();

            bool loginSucesso = funcionario.LoginCidadao(cpfLogin);
            if (loginSucesso)
            {
                Console.WriteLine("Login bem-sucedido! Cidadão cadastrado.");
            }
            else
            {
                Console.WriteLine("Cidadão não cadastrado.");
            }

            Console.WriteLine("\nAgendamento de Vacinação:");
            Console.Write("Data (yyyy-MM-dd): ");
            DateTime dataAgendamento = DateTime.Parse(Console.ReadLine());
            funcionario.AdicionarAgendamento(dataAgendamento);
            funcionario.AgendarVacinação(dataAgendamento);

            Console.WriteLine("\nVacinação:");
            funcionario.Vacinar();
            cidadao.Vacinar();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro na validação dos dados: {ex.Message}");
        }
    }
}