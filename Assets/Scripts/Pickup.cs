using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject productSquare,productCircle,productCapsule;
    public GameObject Logic;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(Logic.GetComponent<Logic>().productAtPickUp)
        {
            if(Logic.GetComponent<Logic>().initSprite == "Sq") productSquare.GetComponent<move>().Follow();
            else if(Logic.GetComponent<Logic>().initSprite == "Ci") productCircle.GetComponent<move>().Follow();
            else productCapsule.GetComponent<move>().Follow();
        }
        //if(collision.gameObject.CompareTag("Player"))

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
