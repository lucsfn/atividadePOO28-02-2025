using System.Collections.Specialized;
using Util;

namespace Main
{
    public class Program
    {
        public static void Main()
        {
            int userInput = 0;

            Console.WriteLine("Olá usuário! Vamos testar as classes!");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            Console.ReadKey();

            do
            {
                // Função para printar opções
                switch (userInput)
                {
                    case 1:
                    // Validar CPF
                    {
                        string cpf;
                        Console.WriteLine("Digite um CPF para que o sistema possa validar:");
                        cpf = Console.ReadLine()!;
                        if (ValidaDados.ValidaCPF(cpf)) Console.WriteLine("CPF Válido!");
                        else Console.WriteLine("CPF inválido!");
                    }
                    break;

                    case 2:
                    // Validar ID
                    // Regra de negócio: ID tem que ser numérico e de 8 dígitos.
                    {
                        string id;
                        Console.WriteLine("Digite um ID para que o sistema possa validar:");
                        id = Console.ReadLine()!;
                        if (ValidaDados.ValidaID(id)) Console.WriteLine("ID Válido!");
                        else Console.WriteLine("ID inválido!");
                    }
                    break;

                    case 3:
                    // Validar e-mail
                    {
                        string email;
                        Console.WriteLine("Digite um email para que o sistema possa validar:");
                        email = Console.ReadLine()!;
                        if (ValidaDados.ValidaID(email)) Console.WriteLine("Email Válido!");
                        else Console.WriteLine("Email inválido!");
                    }
                    break;

                    case 4:
                    // Validar placa de carro
                    {
                        string placaCarro;
                    }
                    break;

                    case 5:
                    // Criar LOG
                    break;

                    case 6:
                    // Traduzir
                    break;

                }
            }
            while (userInput != 0);

            Console.ReadKey();
        }
    }
}