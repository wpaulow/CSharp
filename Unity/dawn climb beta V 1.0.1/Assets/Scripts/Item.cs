using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public LayerMask player;
    public float diametro;
    public bool emCima;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        emCima = Physics2D.OverlapCircle(transform.position, diametro, player);
        if(Geral.clique && emCima)
        {
            Destroy(transform.gameObject);
            Debug.Log("Item pego");
        }
        Geral.clique = false;
    }

    private void OnTriggerEnter2D()
    {
        
    }
}
