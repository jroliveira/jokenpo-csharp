using Jokenpo;
using NUnit.Framework;

namespace JokenpoTest {

    /*
     * [x] Pedra empata com Pedra e ganha de Tesoura
     * [x] Tesoura empata com Tesoura e ganha de Papel
     * [x] Papel empata com Papel e ganha de Pedra
     */

    [TestFixture]
    public class JopenpoTest {

        [Test]
        public void Joookeiiipo_JogadorAEscolhePedraJogadorBEscolhePedra_RetornaNulo() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Pedra},
                                    {"jogadorB", Jogada.Pedra}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.IsEmpty(vencedor);
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePedraJogadorBEscolheTesoura_RetornaJogadorA() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Pedra},
                                    {"jogadorB", Jogada.Tesoura}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorA" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolheTesouraJogadorBEscolhePedra_RetornaJogadorB() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Tesoura},
                                    {"jogadorB", Jogada.Pedra}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorB" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolheTesouraJogadorBEscolhePapel_RetornaJogadorA() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Tesoura},
                                    {"jogadorB", Jogada.Papel}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorA" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePapelJogadorBEscolheTesoura_RetornaJogadorB() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Papel},
                                    {"jogadorB", Jogada.Tesoura}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorB" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolheTesouraJogadorBEscolheTesoura_RetornaNulo() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Tesoura},
                                    {"jogadorB", Jogada.Tesoura}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.IsEmpty(vencedor);
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePapelJogadorBEscolhePapel_RetornaNulo() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Tesoura},
                                    {"jogadorB", Jogada.Tesoura}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.IsEmpty(vencedor);
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePapelJogadorBEscolhePedra_RetornaJogadorB() {
            var jogadores = new Jogadores {
                                    {"jogadorA", Jogada.Papel},
                                    {"jogadorB", Jogada.Pedra}
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorA" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePedraJogadorBEscolhePapel_RetornaJogadorB() {
            var jogadores = new Jogadores {
                                    { "jogadorA", Jogada.Pedra }, 
                                    { "jogadorB", Jogada.Papel }
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorB" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePedraJogadorBEscolhePapelJogadorCEscolheTesoura_RetornaJogadorAJogadorBJogadorC() {
            var jogadores = new Jogadores {
                                    { "jogadorA", Jogada.Pedra }, 
                                    { "jogadorB", Jogada.Papel },
                                    { "jogadorC", Jogada.Tesoura }
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorA", "jogadorB", "jogadorC" });
        }

        [Test]
        public void Joookeiiipo_JogadorAEscolhePedraJogadorBEscolhePedraJogadorCEscolheTesoura_RetornaJogadorAJogadorB() {
            var jogadores = new Jogadores {
                                    { "jogadorA", Jogada.Pedra }, 
                                    { "jogadorB", Jogada.Pedra },
                                    { "jogadorC", Jogada.Tesoura }
                                };

            var jogo = new Jogo();
            var vencedor = jogo.Joookeiiipo(jogadores);

            CollectionAssert.AreEquivalent(vencedor, new[] { "jogadorA", "jogadorB" });
        }
    }
}
