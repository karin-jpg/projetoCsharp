using primeiroProjeto.Interface;

namespace primeiroProjeto.lib
{
    public class Jogador1 : iJogador
{
    public readonly string _nome;

    public Jogador1(string nome = "Karín")
    {
        _nome = nome;
    }
    public string Chutar()
    {
        return $"{_nome} está chutando";
    }

    public string Correr()
    {
        return $"{_nome} está correndo";
    }
    public string Passar()
    {
        return $"{_nome} está passando";
    }
}
}