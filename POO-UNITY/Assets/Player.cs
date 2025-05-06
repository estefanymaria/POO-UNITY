using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float velocidade = 10;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 posicao = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = transform.position.x - velocidade * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = transform.position.x + velocidade * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = transform.position.z + velocidade * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = transform.position.z - velocidade * Time.deltaTime;
        }

        transform.position = posicao;

    }
    
}