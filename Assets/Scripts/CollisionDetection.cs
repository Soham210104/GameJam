using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // public SpriteRenderer sR;
    public GameObject options;

    // Start is called before the first frame update
    void Start()
    {
        // sR = GetComponent<SpriteRenderer>();
        //options = GetComponent<GameObject>();
        Hide();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void Hide()
    {
        // sR.enabled = false;
        options.SetActive(false);
        //Debug.Log("Hide");

    }
    void Show()
    {
        // sR.enabled = true;
        options.SetActive(true);
        //Debug.Log("Show");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        // if(other.CompareTag("Player")) 
        Show();
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        // if(other.CompareTag("Player")) 
        Hide();
    }
}
