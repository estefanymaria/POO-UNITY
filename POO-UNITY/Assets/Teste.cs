using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();

    void Start()
    {
        fusca.setNome("Fusca de Pai");
        fusca.setCor("Verde");

        Debug.Log("O " + fusca.getNome() + " é " + fusca.getCor());
    }
}