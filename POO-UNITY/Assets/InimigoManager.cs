using UnityEngine;

public class InimigoManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoDoInimigo movimentoDoInimigo;
    public float velocidadeDaAnimacao = 1;

    void Start()
    {
        movimentoDoInimigo = GetComponent<MovimentoDoInimigo>();
    }

    void Update()
    {
        animator.SetBool("Perseguindo", movimentoDoInimigo.naVisao);
        animator.speed = velocidadeDaAnimacao;
    }
}