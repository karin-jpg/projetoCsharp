using primeiroProjeto.Interface;

namespace primeiroProjeto
{
        public class jogoDoido
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;
    
        public jogoDoido(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void iniciarJogo()
        {
            System.Console.WriteLine(_jogador1.Correr());
            System.Console.WriteLine(_jogador1.Chutar());
            System.Console.WriteLine(_jogador1.Passar());

            System.Console.WriteLine("\nPróximo Jogador\n");

            System.Console.WriteLine(_jogador2.Correr());
            System.Console.WriteLine(_jogador2.Chutar());
            System.Console.WriteLine(_jogador2.Passar());
        }
    
    }
}