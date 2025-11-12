using UnityEngine;

public class Arqueiro : Personagem
{
    [SerializeField] private int flechas;

    public Arqueiro(string nome, int vida, int flechas) : base(nome, vida)
    {
        this.flechas = flechas;
    }

    public void AtirarFlechas()
    {
        if(flechas > 0)
        {
            flechas--;
            Debug.Log("Atirando flechas. Flechas restantes = " + flechas);
        }
    }
}
