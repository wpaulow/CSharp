using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D bodyP1;
    public Transform checkFloor;
    public LayerMask whatFloor;

    public float puloForca;
    public float velocidade;
    public bool onFloor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        bodyP1.velocity = new Vector2(move*velocidade, bodyP1.velocity.y);

        if (Input.GetKey(KeyCode.W) && onFloor)
        {
            bodyP1.AddForce(new Vector2(0, puloForca));
        }

        onFloor = Physics2D.OverlapCircle(checkFloor.position, 0.2f, whatFloor);
        Debug.Log(onFloor);
    }
}
