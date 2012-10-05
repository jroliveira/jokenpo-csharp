using System.Collections.Generic;
using System.Linq;

namespace Jokenpo {

    public static class JogadoresExtension {

        public static IEnumerable<string> VencedoresPara(this Dictionary<string, Jogada> jogadores, Jogada jogada) {
            var vencedores = new List<string>();
            foreach (var jogador in jogadores)
                if (jogador.Value == jogada)
                    vencedores.Add(jogador.Key);

            return vencedores.ToList();
        }
    }
}