using System;
using UnityEngine;

public class MovimentoDoInimigo : MonoBehaviour
{
    private GameObject _player;

    private Rigidbody _rigidbody;
    private float velocidade;

    public float RaioDeVisao = 10;
    private bool naVisao = false;

    private SphereCollider _sphereCollider;

    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        
        _player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        _sphereCollider.radius = RaioDeVisao;

        if (naVisao == true)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position,
                _player.transform.position,
                velocidade * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
    }

    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
}