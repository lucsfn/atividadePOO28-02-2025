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

        
    }
}