using System;
using primeiroProjeto.lib;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoDoido(new Jogador2(), new Jogador1());
            jogo.iniciarJogo();
        }
    }
}