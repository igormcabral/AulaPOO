using UnityEngine;

public class TesteHeranca : MonoBehaviour
{
    private void Start()
    {
        Arqueiro a = new Arqueiro("arqueiro", 50, 10);
        a.AtirarFlechas();
    }
}
