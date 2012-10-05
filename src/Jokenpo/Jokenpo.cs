using System.Collections.Generic;

namespace Jokenpo {

    public class Jogo {

        public IEnumerable<string> Joookeiiipo(Dictionary<string, Jogada> jogadores) {
            var vencedores = new List<string>();

            if (jogadores.ContainsValue(Jogada.Pedra) && jogadores.ContainsValue(Jogada.Tesoura))
                vencedores.AddRange(jogadores.VencedoresPara(Jogada.Pedra));

            if (jogadores.ContainsValue(Jogada.Pedra) && jogadores.ContainsValue(Jogada.Papel))
                vencedores.AddRange(jogadores.VencedoresPara(Jogada.Papel));

            if (jogadores.ContainsValue(Jogada.Tesoura) && jogadores.ContainsValue(Jogada.Papel))
                vencedores.AddRange(jogadores.VencedoresPara(Jogada.Tesoura));

            return vencedores;
        }
    }
}
