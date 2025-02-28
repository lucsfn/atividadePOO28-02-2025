using util;

namespace Main
{
    public class Program
    {
        public static void Main()
        {
            int inputUsuario;

            ImprimeMensagemInicial();

            do
            {
                ImprimeOpcoes();
                inputUsuario = int.Parse(Console.ReadLine()!);
                ControlaOpcoes(inputUsuario);
            }
            while (inputUsuario != 0);
        }

        public static void ImprimeMensagemInicial()
        {
            Console.WriteLine("Olá usuário! Vamos testar as classes!");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            Console.ReadKey();
        }

        public static void ImprimeOpcoes()
        {
            Console.Clear();
            Console.WriteLine("===============================================\n");
            Console.WriteLine("As opções são as seguintes:");
            Console.WriteLine("1 - Validar CPF");
            Console.WriteLine("2 - Validar ID");
            Console.WriteLine("3 - Validar e-mail");
            Console.WriteLine("4 - Validar placa de carro");
            Console.WriteLine("5 - Logger centralizado");
            Console.WriteLine("6 - Traduzir uma palavra");
            Console.WriteLine("0 - Encerrar o programa");
            Console.WriteLine("\n===============================================\n");
        }

        public static void ControlaOpcoes(int inputUsuario)
        {
            switch (inputUsuario)
            {
                case 1:
                    // Validar CPF
                    {
                        Console.Clear();
                        string cpf;
                        Console.WriteLine("Digite um CPF para que o sistema possa validar:");
                        cpf = Console.ReadLine()!;
                        if (ValidaDados.ValidaCPF(cpf)) Console.WriteLine("CPF Válido!");
                        else Console.WriteLine("CPF inválido!");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    // Validar ID
                    // Regra de negócio: ID tem que ser numérico e de 8 dígitos.
                    {
                        Console.Clear();
                        string id;
                        Console.WriteLine("Digite um ID para que o sistema possa validar. PS: O ID válido para o sistema ter que ser numérico e possuir 8 dígitos");
                        id = Console.ReadLine()!;
                        if (ValidaDados.ValidaID(id)) Console.WriteLine("ID Válido!");
                        else Console.WriteLine("ID inválido!");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    // Validar e-mail
                    {
                        Console.Clear();
                        string email;
                        Console.WriteLine("Digite um email para que o sistema possa validar:");
                        email = Console.ReadLine()!;
                        if (ValidaDados.ValidaEmail(email)) Console.WriteLine("Email Válido!");
                        else Console.WriteLine("Email inválido!");
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    // Validar placa de carro
                    {
                        Console.Clear();
                        string placaDeCarro;
                        Console.WriteLine("Digite uma placa de carro para que o sistema possa validar. PS: A validação se encontra com a regra dos novos padrões de placa: AAA1A11");
                        placaDeCarro = Console.ReadLine()!;
                        if (ValidaDados.ValidaPlacaDeCarro(placaDeCarro)) Console.WriteLine("Placa de carro Válido!");
                        else Console.WriteLine("Placa de carro inválido!");
                        Console.ReadKey();
                    }
                    break;

                case 5:
                    // Criar LOG
                    {
                        Console.Clear();
                        Console.WriteLine("Funcionalidade ainda não implementada!");
                        Console.ReadKey();
                    }
                    break;

                case 6:
                    // Traduzir
                    {
                        Console.Clear();
                        string palavra;
                        string idioma;
                        Console.WriteLine("Digite a palavra que você quer traduzir (EM PORTUGUÊS!):");
                        palavra = Console.ReadLine()!;
                        Console.WriteLine("Digite o idioma para o qual você quer traduzir: ('en' = inglês, 'es' = espanhol e 'fr' = francês)");
                        idioma = Console.ReadLine()!;
                        Console.WriteLine(Traducao.Traduzir(palavra, idioma));
                        Console.ReadKey();
                    }
                    break;

                default:
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
                    break;

            }
        }

    }

}