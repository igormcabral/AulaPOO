using Unity.VisualScripting;
using UnityEngine;

public class TesteAula05 : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Herói", 100);
        Inimigo inimigo = new Inimigo("Monstro", 80, 15);

        player.gritar();
        inimigo.gritar();
        inimigo.reclamar();
        player.SetNome("Super Herói");
        Personagem p = new Personagem("Genérico", 50);
        p.gritar();
        p.SetVida(70);
    }

}
