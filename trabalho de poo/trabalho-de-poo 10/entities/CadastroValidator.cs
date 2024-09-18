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

        public bool ValidarCPF(string cpf)
        {
            if (Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                return true;
            }
            throw new ArgumentException("CPF inválido. Deve estar no formato XXX.XXX.XXX-XX.");
        }

        public bool ValidarNome(string nome)
        {
            if (Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
            {
                return true;
            }
            throw new ArgumentException("Nome inválido. Deve conter apenas caracteres alfabéticos.");
        }

        public bool ValidarData(string data, bool isFuturo)
        {
            DateTime parsedDate;
            if (DateTime.TryParse(data, out parsedDate))
            {
                if (isFuturo && parsedDate > DateTime.Now)
                {
                    return true;
                }
                else if (!isFuturo && parsedDate < DateTime.Now)
                {
                    return true;
                }
            }
            throw new ArgumentException("Data inválida.");
        }
    }
}