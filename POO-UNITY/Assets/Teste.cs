using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    Caminhao caminhao = new Caminhao();

    void Start()
    {
        fusca.setNome("Fusca de Pai");
        fusca.setCor("Amarelo");
        fusca.setNumero_de_rodas(4);
        fusca.setPreco(2050.90f);
        Debug.Log("O " + fusca.getNome() + " é " + fusca.getCor() + " tem " + fusca.getNumero_de_rodas() + " e custa R$" + fusca.getPreco());

        gol.setNome("Gol do Falstão");
        gol.setCor("Verde");
        gol.setNumero_de_rodas(4);
        gol.setPreco(3000.00f);
        Debug.Log("0 " + gol.getNome());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais caro do que o carro " + gol.getNome());
        }
        else
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais barato do que o carro " + gol.getNome());
        }

        caminhao.setTipoDeCarroceria("Larga");
        caminhao.setNumero_de_rodas(8);
        caminhao.setPreco(6000.00f);
        caminhao.setCor("Azul");
        caminhao.setNome("Caminhao do Falstão");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O Carro " + fusca.getNome() + " é mais caro do que o " + caminhao.getNome());
        }
        else
        {
            Debug.Log("0 Carro " + fusca.getNome() + " é mais barato do que o " + caminhao.getNome());
        }
    }
}