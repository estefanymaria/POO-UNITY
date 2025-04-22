using UnityEngine;

public class Inimigo : Personagem
{
    private string armadura;
    private string arma;

    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }

    public string Arma()
    {
        return this.arma;
    }

    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "ESPADA";
                dano = AtribuirForca_Ataque() + 10;
                break; 
            case "MACHADO";
                dano = AtribuirForca_Ataque() + 18;
                break;
            case "ADAGA";
                dano = AtribuirForca_Ataque() + 5;
                break;
                
        }
        
        return dano;
    }
}