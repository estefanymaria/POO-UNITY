using UnityEngine;

public class MovimentoDoInimigo : MonoBehaviour
{
    private GameObject _player;
    private Rigidbody _rigidbody;
    private float velocidade;
    public float RaioDeVisao = 10;
    
    [HideInInspector] public bool naVisao = false; // Agora acessível por InimigoManager

    private SphereCollider _sphereCollider;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        velocidade = GetComponent<Inimigo>().Velocidade();
        _sphereCollider = GetComponent<SphereCollider>();
        _player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        _sphereCollider.radius = RaioDeVisao;

        if (naVisao)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position,
                _player.transform.position,
                velocidade * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            naVisao = true;
        }
    }

    void OnTriggerExit(Collider colisao)
    {
        if (colisao.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
}