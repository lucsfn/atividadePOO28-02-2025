namespace Util
{
    public static class Traducao
    {
        // Essa classe deve funcionar como um dicionário para algumas línguas, sendo capaz de traduzir as 100 palavras mais utilizadas em inglês, espanhol e francês

        // Dicionário com as 100 palavras
        private static readonly Dictionary<string, Dictionary<string, string>> dicionario = new Dictionary<string, Dictionary<string, string>>()
    {
        {"olá", new Dictionary<string, string>{{"en", "hello"}, {"es", "hola"}, {"fr", "bonjour"}}},
        {"adeus", new Dictionary<string, string>{{"en", "goodbye"}, {"es", "adiós"}, {"fr", "au revoir"}}},
        {"por favor", new Dictionary<string, string>{{"en", "please"}, {"es", "por favor"}, {"fr", "s'il vous plaît"}}},
        {"obrigado", new Dictionary<string, string>{{"en", "thank you"}, {"es", "gracias"}, {"fr", "merci"}}},
        {"desculpe", new Dictionary<string, string>{{"en", "sorry"}, {"es", "lo siento"}, {"fr", "désolé"}}},
        {"sim", new Dictionary<string, string>{{"en", "yes"}, {"es", "sí"}, {"fr", "oui"}}},
        {"não", new Dictionary<string, string>{{"en", "no"}, {"es", "no"}, {"fr", "non"}}},
        {"homem", new Dictionary<string, string>{{"en", "man"}, {"es", "hombre"}, {"fr", "homme"}}},
        {"mulher", new Dictionary<string, string>{{"en", "woman"}, {"es", "mujer"}, {"fr", "femme"}}},
        {"criança", new Dictionary<string, string>{{"en", "child"}, {"es", "niño"}, {"fr", "enfant"}}},
        {"água", new Dictionary<string, string>{{"en", "water"}, {"es", "agua"}, {"fr", "eau"}}},
        {"comida", new Dictionary<string, string>{{"en", "food"}, {"es", "comida"}, {"fr", "nourriture"}}},
        {"casa", new Dictionary<string, string>{{"en", "house"}, {"es", "casa"}, {"fr", "maison"}}},
        {"carro", new Dictionary<string, string>{{"en", "car"}, {"es", "coche"}, {"fr", "voiture"}}},
        {"dia", new Dictionary<string, string>{{"en", "day"}, {"es", "día"}, {"fr", "jour"}}},
        {"noite", new Dictionary<string, string>{{"en", "night"}, {"es", "noche"}, {"fr", "nuit"}}},
        {"amor", new Dictionary<string, string>{{"en", "love"}, {"es", "amor"}, {"fr", "amour"}}},
        {"amigo", new Dictionary<string, string>{{"en", "friend"}, {"es", "amigo"}, {"fr", "ami"}}},
        {"família", new Dictionary<string, string>{{"en", "family"}, {"es", "familia"}, {"fr", "famille"}}},
        {"trabalho", new Dictionary<string, string>{{"en", "work"}, {"es", "trabajo"}, {"fr", "travail"}}},
        {"dinheiro", new Dictionary<string, string>{{"en", "money"}, {"es", "dinero"}, {"fr", "argent"}}},
        {"escola", new Dictionary<string, string>{{"en", "school"}, {"es", "escuela"}, {"fr", "école"}}},
        {"livro", new Dictionary<string, string>{{"en", "book"}, {"es", "libro"}, {"fr", "livre"}}},
        {"cidade", new Dictionary<string, string>{{"en", "city"}, {"es", "ciudad"}, {"fr", "ville"}}},
        {"país", new Dictionary<string, string>{{"en", "country"}, {"es", "país"}, {"fr", "pays"}}},
        {"rua", new Dictionary<string, string>{{"en", "street"}, {"es", "calle"}, {"fr", "rue"}}},
        {"grande", new Dictionary<string, string>{{"en", "big"}, {"es", "grande"}, {"fr", "grand"}}},
        {"pequeno", new Dictionary<string, string>{{"en", "small"}, {"es", "pequeño"}, {"fr", "petit"}}},
        {"rápido", new Dictionary<string, string>{{"en", "fast"}, {"es", "rápido"}, {"fr", "rapide"}}},
        {"lento", new Dictionary<string, string>{{"en", "slow"}, {"es", "lento"}, {"fr", "lent"}}},
        {"quente", new Dictionary<string, string>{{"en", "hot"}, {"es", "caliente"}, {"fr", "chaud"}}},
        {"frio", new Dictionary<string, string>{{"en", "cold"}, {"es", "frío"}, {"fr", "froid"}}},
        {"feliz", new Dictionary<string, string>{{"en", "happy"}, {"es", "feliz"}, {"fr", "heureux"}}},
        {"triste", new Dictionary<string, string>{{"en", "sad"}, {"es", "triste"}, {"fr", "triste"}}},
        {"pai", new Dictionary<string, string>{{"en", "father"}, {"es", "padre"}, {"fr", "père"}}},
        {"mãe", new Dictionary<string, string>{{"en", "mother"}, {"es", "madre"}, {"fr", "mère"}}},
        {"irmão", new Dictionary<string, string>{{"en", "brother"}, {"es", "hermano"}, {"fr", "frère"}}},
        {"irmã", new Dictionary<string, string>{{"en", "sister"}, {"es", "hermana"}, {"fr", "sœur"}}}
    };

        public static string Traduzir(string palavraChave, string idioma)
        {
            if (dicionario.TryGetValue(palavraChave.ToLower(), out var traducoes))
            {
                if (traducoes.TryGetValue(idioma, out var traducao))
                {
                    return traducao;
                }
                return "Idioma não suportado.";
            }
            return "Palavra não encontrada.";
        }
    }
}