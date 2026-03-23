using UnityEngine;

public class JogoConsole : MonoBehaviour
{

    public int vidaHeroi = 100;

    public string inimigoCenario1;
    public int danoCenario1;
    public int recompensaCenario1;

    public string inimigoCenario2;
    public int danoCenario2;

    public string bossFinal;
   

    void Start()
    {
        Debug.Log("=== INÍCIO DO JOGO ===");
        Debug.Log("Vida inicial do Herói: " + vidaHeroi);

        Cenario1();
        Cenario2();
        Cenario3();

        Debug.Log("=== FIM DO JOGO ===");
    }

    void Cenario1()
    {
        Debug.Log("=== CENÁRIO 1 ===");
        Debug.Log("Herói encontrou um inimigo fraco!");

        int danoInimigo = 10;
        int recompensa = 20;

        vidaHeroi -= danoInimigo;
        Debug.Log("Herói sofreu dano de: " + danoInimigo);

        vidaHeroi += recompensa;
        Debug.Log("Herói venceu e ganhou vida: " + recompensa);

        Debug.Log("Vida atual: " + vidaHeroi);
    }

    void Cenario2()
    {
        Debug.Log("=== CENÁRIO 2 ===");
        Debug.Log("Herói encontrou um inimigo forte!");

        int danoInimigo = 40;

        vidaHeroi -= danoInimigo;
        Debug.Log("Herói perdeu a batalha!");
        Debug.Log("Dano recebido: " + danoInimigo);

        if (vidaHeroi <= 0)
        {
            vidaHeroi = 10; // não deixa morrer
            Debug.Log("Herói quase morreu, mas sobreviveu!");
        }

        Debug.Log("Vida atual: " + vidaHeroi);
    }

    void Cenario3()
    {
        Debug.Log("=== CENÁRIO FINAL (BOSS) ===");
        Debug.Log("O chefe mais temido apareceu!");

        int danoBoss = vidaHeroi;

        vidaHeroi -= danoBoss;

        Debug.Log("O Boss atacou com força máxima!");
        Debug.Log("Herói perdeu toda a vida!");

        if (vidaHeroi <= 0)
        {
            Debug.Log("💀 Herói morreu...");
        }
    }
}