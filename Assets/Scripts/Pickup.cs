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
            Logic.GetComponent<Logic>().f1 = true;
            if(Logic.GetComponent<Logic>().initSprite == "Sq") productSquare.GetComponent<move>().Follow(Logic.GetComponent<Logic>().s);
            else if(Logic.GetComponent<Logic>().initSprite == "Ci") productCircle.GetComponent<move>().Follow(Logic.GetComponent<Logic>().s);
            else productCapsule.GetComponent<move>().Follow(Logic.GetComponent<Logic>().s);
        }
        //if(collision.gameObject.CompareTag("Player"))

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
