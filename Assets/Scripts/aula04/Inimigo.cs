using UnityEngine;

public class Inimigo : Personagem
{

    private int dano;

    public Inimigo(string nome, int vida, int dano) : base(nome, vida)
    {
        this.dano = dano;
    }
    public void Atacar(Player player)
    {
        player.ReceberDano(dano);
        Debug.Log($"{nome} atacou {player.GetNome()}, " +
            $"causando {dano} de dano!");
    }
    public void ReceberDano(int dano)
    {
        vida -= dano;
        Debug.Log($"{nome} recebeu {dano} de dano. " +
            $"Vida restante: {vida}");
        if (vida <= 0)
        {
            Debug.Log($"{nome} foi derrotado!");
        }
    }
    public void reclamar()
    {
        Debug.Log("chega!!!!");
    }

}
