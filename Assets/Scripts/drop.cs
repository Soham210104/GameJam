using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public GameObject Product;
    GameObject childObject;
    public Transform childTransform;
    // Start is called before the first frame update
    void Start()
    {
        Product = GameObject.FindWithTag("Product");
        childObject = Product;
        //childTransform = Product.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //childObject.transform.parent = null; //childObject ko hi null karege
        //Product.transform = new Vector2(1.52f,-3.6f); 
        //childObject.transform.position = new Vector2(1.52f, -3.6f); //child ko hi toh detach karke change karvana hai

        Product.GetComponent<move>().dropBox();
    }

}
