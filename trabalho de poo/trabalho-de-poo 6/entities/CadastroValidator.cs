using System;
using System.Text.RegularExpressions;

namespace Validators
{
    public class CadastroValidator
    {
        public bool VerificarIdade(int idade)
        {
            if (idade > 0 && idade < 200)
            {
                return true;
            }
            throw new ArgumentException("Idade inválida. Deve ser maior que 0 e menor que 200.");
        }

        public bool VerificarCPF(string cpf)
        {
            if (Regex.IsMatch(cpf, @"^\d{11}$"))
            {
                return true;
            }
            throw new ArgumentException("CPF inválido. Deve conter 11 dígitos.");
        }

        public bool VerificarEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            throw new ArgumentException("E-mail inválido.");
        }

        public bool VerificarTelefone(string telefone)
        {
            if (Regex.IsMatch(telefone, @"^\d{10,11}$"))
            {
                return true;
            }
            throw new ArgumentException("Telefone inválido. Deve conter 10 ou 11 dígitos.");
        }

        // Adicione mais métodos de validação conforme necessário.
    }
}