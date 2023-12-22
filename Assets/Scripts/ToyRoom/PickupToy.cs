using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupToy : MonoBehaviour
{
    public GameObject product;
    public GameObject Logic;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Logic.GetComponent<ToyLogic>().productAtPickUp)
        {
            //Logic.GetComponent<ToyLogic>().f1 = true;
            product.GetComponent<move>().Follow(Logic.GetComponent<ToyLogic>().s);

        }
        //if(collision.gameObject.CompareTag("Player"))
    }
    void OnCollisionExit2D(Collision2D collision)
    {

    }
}
