using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public GameObject Product;
    public GameObject ProductToy;
    // Start is called before the first frame update
    void Start()
    {
        Product = GameObject.FindWithTag("Product");
        ProductToy = GameObject.FindWithTag("ProductToy");
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Product != null)
        {
            Product.GetComponent<move>().dropBox();
        }
        else if(ProductToy != null)
        {
            ProductToy.GetComponent<move>().dropToy();
        }
    }
}
