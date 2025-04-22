using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private int energia;
    private int forca_ataque;
    private int forca_do_pulo;
    private float velocidade;
    private int numero_de_pes;
    private int numero_de_maos;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }
    
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }
    
    public void AtribuirForca_Ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Energia()
    {
        return this.forca_ataque;
    }