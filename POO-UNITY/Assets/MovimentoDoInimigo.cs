using System;
using UnityEngine;

public class MovimentoDoInimigo : MonoBehaviour
{
    private GameObject _player;

    private Rigidbody _rigidbody;
    private float velocidade;

    public float RaioDeVisao = 3;

    void Start()
    {
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _rigidbody = gameObject.GetComponent<Rigidbody>();

        _player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < RaioDeVisao)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position,
                _player.transform.position,
                velocidade * Time.deltaTime);
        }
    }
}