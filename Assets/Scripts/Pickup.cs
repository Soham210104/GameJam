using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject product;
    public GameObject Logic;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(Logic.GetComponent<Logic>().productAtPickUp)
        {
            Logic.GetComponent<Logic>().f1 = true;
            product.GetComponent<move>().Follow(Logic.GetComponent<Logic>().s);
            
        }
        //if(collision.gameObject.CompareTag("Player"))
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
