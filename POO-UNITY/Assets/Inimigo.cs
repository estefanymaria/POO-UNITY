using UnityEngine;

public class Inimigo : Personagem
{
    public enum ArmaDoInimigo
    {
        ESPADA, MACHADO, ADAGA
    }

    public enum ArmaduraDoInimigo
    {
        MADEIRA, COURO, BRONZE, ACO
    }
    
    [ SerializeField ]
    private ArmaduraDoInimigo armadura;
    [ SerializeField ]
    private ArmaDoInimigo arma;

    public void AtribuirArmadura(ArmaduraDoInimigo armadura)
    {
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(ArmaDoInimigo arma)
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
            case "ESPADA":
                dano = Forca_Ataque() + 10;
                break; 
            case "MACHADO":
                dano = Forca_Ataque() + 18;
                break;
            case "ADAGA":
                dano = Forca_Ataque() + 5;
                break;
                
        }
        
        return dano;
    }
}