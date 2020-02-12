using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    public Rigidbody2D bodyP1;
    public Transform checkFloor;
    public GameObject item;
    public SpriteRenderer sprite;
    public LayerMask whatFloor;

    public float puloForca;
    public float velocidade;
    public bool onFloor;


    public bool puloDuplo;
    public int contPulo;
    public int contTiro;


    // Start is called before the first frame update
    void Start()
    {
        puloDuplo = false;
        contPulo = 0;
        contTiro = 0;
    }

    // Update is called once per frame
    void Update()
    {
//=================================MODO PREGUIÇOSO DE FAZER UM OBJETO SE MOVER============================================================================

        //Mover(temporario)
        float move = Input.GetAxis("Horizontal2");
        bodyP1.velocity = new Vector2(move * velocidade, bodyP1.velocity.y);
        if (move > 0)
            sprite.flipX = false;
        if (move < 0)
            sprite.flipX = true;

        //=================================PULO============================================================================

        //Pular enquanto estiver no chão
        if (Input.GetKeyDown(KeyCode.UpArrow) && onFloor)
        {
            bodyP1.AddForce(new Vector2(0, puloForca * 100));
        }

        //Caso não esteja no chão, mas o pulo duplo estar habilitado
        else if (Input.GetKeyDown(KeyCode.UpArrow) && puloDuplo)
        {
            bodyP1.AddForce(new Vector2(0, puloForca * 100));
            puloDuplo = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Geral.clique = true;
        }
//=============================VERIFICADOR DE CONTATO COM CHÃO================================================================================

        onFloor = Physics2D.OverlapCircle(checkFloor.position, 0.2f, whatFloor); //Verifica se o corpo do personagem está em contato com o chão(floor)
        if (onFloor)
        {
            puloDuplo = true; //Se estiver em contato com o chão, habilita o pulo duplo  
        }

    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        
    }
}
