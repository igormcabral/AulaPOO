using UnityEngine;

//public enum TipoPersonagem
//{
//    Guerreiro,
//    Mago,
//    Arqueiro
//}
public class Personagem
{
    //private TipoPersonagem tipo;
    protected string nome;
    protected int vida;
    //private TipoPersonagem tipo;

    public Personagem(string nome, int vida)
    {
        this.nome = nome;
        if (vida > 100)
        {
            this.vida = 100;
        }
        this.vida = vida;
    }

    public void gritar()
    {
        Debug.Log("AAAAAAAH!");
    }

    //public TipoPersonagem GetTipoPersonagem() 
    //{ 
    //    return tipo; 
    //}
    //public void SetTipoPersonagem(TipoPersonagem tipo)
    //{
    //    this.tipo = tipo;
    //}
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public int GetVida()
    {
        return vida;
    }
    public void SetVida(int vida)
    {
        this.vida = vida;
    }
}
