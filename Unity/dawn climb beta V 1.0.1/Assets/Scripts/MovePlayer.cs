using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D bodyP1;

    public Transform checkFloor;
    public LayerMask whatFloor;

    public Transform checkEscada;
    public LayerMask whatEscada;

    public GameObject item;
    public SpriteRenderer sprite;

    

    public float puloForca;
    public float velocidade;
    public bool onFloor;
    public bool onEscada;
    

    public bool puloDuplo;
    public bool subindo;
    public int contPulo;
    public int contTiro;
    public float posEscada;


    // Start is called before the first frame update
    void Start()
    {
        subindo = false;
        puloDuplo = false;
        contPulo = 0;
        contTiro = 0;
    }

    // Update is called once per frame
    void Update()
    {
//=================================MODO PREGUIÇOSO DE FAZER UM OBJETO SE MOVER============================================================================

        //Mover(temporario)
        float move = Input.GetAxis("Horizontal");
        bodyP1.velocity = new Vector2(move*velocidade, bodyP1.velocity.y);
        if (move > 0)
            sprite.flipX = false;
        if (move < 0)
            sprite.flipX = true;

        //=================================PULO============================================================================

        //Pular enquanto estiver no chão
        if (Input.GetKeyDown(KeyCode.W) && onFloor)
        {
            bodyP1.AddForce(new Vector2(0, puloForca*100));
        }
        //Caso não esteja no chão, mas o pulo duplo estar habilitado
        else if(Input.GetKeyDown(KeyCode.W) && puloDuplo)
        {
            bodyP1.AddForce(new Vector2(0, puloForca * 100));
            puloDuplo = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Geral.clique = true;
        }


//=============================Subindo escadas================================================================================
        //Subindo
        if (Input.GetKey(KeyCode.W) && onEscada)
        {
            subindo = true;
            bodyP1.velocity = new Vector2(bodyP1.velocity.x, 1.5f);
            Debug.Log("Subindo");
        }
        if (Input.GetKeyUp(KeyCode.W) && onEscada)
        {
            subindo = false;
            Debug.Log("Soltou");
        }

        //Descendo
        if (Input.GetKey(KeyCode.S) && onEscada)
        {
            subindo = true;
            bodyP1.velocity = new Vector2(bodyP1.velocity.x, -1.5f);
            Debug.Log("Descendo");
        }
        if (Input.GetKeyUp(KeyCode.S) && onEscada)
        {
            subindo = false;
            Debug.Log("Soltou");
        }
        //=============================VERIFICADOR DE CONTATO COM CHÃO================================================================================

        onFloor = Physics2D.OverlapCircle(checkFloor.position, 0.2f, whatFloor); //Verifica se o corpo do personagem está em contato com o chão(floor)
        if (onFloor)
        {
            puloDuplo = true; //Se estiver em contato com o chão, habilita o pulo duplo  
        }

        onEscada = Physics2D.OverlapCircle(checkEscada.position, 0.2f, whatEscada);
        if (onEscada)
        {
            if (subindo)
            {
                bodyP1.constraints = RigidbodyConstraints2D.None;
                bodyP1.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
                
            if (!subindo)
            {
                bodyP1.constraints = RigidbodyConstraints2D.FreezeRotation;
                bodyP1.constraints = RigidbodyConstraints2D.FreezePositionY;
            }
        }
        else if (!onEscada)
        {
            bodyP1.constraints = RigidbodyConstraints2D.None;
            bodyP1.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {

        Debug.Log("Pow!!!");
    }
}
