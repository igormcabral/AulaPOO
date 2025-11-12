using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Player : Personagem
{
    private List<Arma> armas = new List<Arma>();
    private Armadura armadura;
    private Escudo escudo;

    public Player(string nome, int vida) : base(nome, vida)
    {
    }

    public void setArma(Arma arma)
    {
        armas.Add(arma);
    }
    public List<Arma> getArmas()
    {
        return armas;
    }
    public void setArmadura(Armadura armadura)
    {
        this.armadura = armadura;
    }
    public Armadura getArmadura()
    {
        return armadura;
    }
    public void setEscudo(Escudo escudo)
    {
        this.escudo = escudo;
    }
    public Escudo getEscudo()
    {
        return escudo;
    }
    public void ReceberDano(int dano)
    {
        //Vida -= dano - (defesa da armadura + defesaExtra do escudo) 
        int defesaTotal = armadura.getDefesa() + escudo.getDefesaExtra();
        int danoFinal = dano - defesaTotal;
        vida = vida - danoFinal;
        Debug.Log($"{nome} recebeu {danoFinal} de dano após " +
                   $"defesa({ defesaTotal}). Vida restante: { vida}");
    }
    public void Atacar(Inimigo inimigo, Arma arma)
    {
        inimigo.ReceberDano(arma.getDano());
        Debug.Log($"{nome} atacou {inimigo.GetNome()} com {arma.getNome()}," +
            $" causando {arma.getDano()} de dano!");
    }

}
