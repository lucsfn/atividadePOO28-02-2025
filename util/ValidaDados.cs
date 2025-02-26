namespace Util
{
    public static class ValidaDados
    {
        public static bool ValidaCPF(string cpf)
        {

            if (cpf.Length != 11) return false;
            if (cpf.Distinct().Count() == 1) return false;

            int[] pesos1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
            int[] pesos2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

            // CPF é validado a partir da verificação dos DVs, se o cálculo do DV com os 9 primeiros dígitos for igual ao DV informado inicialmente, o CPF tá validado

            int primeiroDV = CalcularDigitoVerificador(cpf[..9], pesos1);
            int segundoDV = CalcularDigitoVerificador(cpf[..9] + primeiroDV, pesos2);

            return cpf.EndsWith(primeiroDV.ToString() + segundoDV.ToString());

        }

        private static int CalcularDigitoVerificador(string numeros, int[] pesos)
        {
            int soma = numeros.Select((t, i) => (t - '0') * pesos[i]).Sum();
            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }

        public static bool ValidaID(string id)
        {
            // Regra de negócio: ID tem que ter 8 dígitos
            if (string.IsNullOrEmpty(id)) return false;
            return id.Length == 8 && int.TryParse(id, out _);
        }

        public static bool ValidaEmail(string email)
        {
            // O que é considerado um email válido? Para a lógica desse código: tem que ter a parte local válida, tem que ter o "@" seguido de um domínio válido e uma extensão de domínio válida.
            string[] dominiosValidos = ["gmail.com", "outlook.com", "hotmail.com", "yahoo.com", "live.com"];

            string[] partes = email.Split('@');

            if (partes.Length == 2)
            {
                string dominio = partes[1];
                return dominiosValidos.Contains(dominio);
            }
            
            return false;
        }





    }
}