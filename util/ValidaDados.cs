namespace Util
{
    public static class ValidaDados
    {
        private static bool ValidaCPF(string cpf)
        {
            // Essa função espera receber o CPF já num formato de 11 dígitos, ou seja, essa validação tem que ser feita na entrada dos daods

            if (cpf.Distinct().Count() == 1) return false; // CPF não pode ter todos os números iguais

            int[] pesos1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
            int[] pesos2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

            // CPF é validado a partir da verificação dos DVs, se o cálculo do DV com os 9 primeiros dígitos for igual ao DV informado inicialmente, o CPF tá validado

            int primeiroDV = CalcularDigitoVerificador(cpf[..9], pesos1);
            int segundoDV = CalcularDigitoVerificador(cpf[..9] + primeiroDV, pesos2);

            return cpf.EndsWith(primeiroDV.ToString() + segundoDV.ToString());

        }

        private static int CalcularDigitoVerificador(string numeros, int[] pesos)
        {
            int soma = numeros.Select((t, i) => (t - '0') * pesos[i]).Sum(); // Transforma cada valor da string em um inteiro, multiplica pelo peso e soma-os
            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }


    }
}