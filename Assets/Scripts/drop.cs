using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public GameObject Product;
    public GameObject ProductToy;
    //public GameObject BoxSpawner,ToySpawner;
    public BoxSpawner bS;
    public ToySpawner tS;
    //public GameObject BoxSpawner,
    //public string b, t;
    public string identity;
    public  string goalBox,goalToy;
    // Start is called before the first frame update
    void Start()
    {
        bS = GameObject.FindWithTag("BoxSpawner").GetComponent<BoxSpawner>();
        tS = GameObject.FindWithTag("ToySpawner").GetComponent<ToySpawner>();
        goalBox = bS.prefabName;
        goalToy = tS.prefabName;
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
            bS.CompareBox();
           
            //if (identity == goalBox) Debug.Log("Correct!");
            /*  identity = Product.GetComponent<move>().identity;
              //goalBox = b;
              //Debug.Log("GOAAAAAALBOXXXXXXXX" + goalBox);
              if (identity == goalBox)
              {
                  Debug.Log("Correct!");
                  //BoxSpawner.GetComponent<BoxSpawner>().Spawner();
                  bS.Spawner();
              }
              else Destroy(Product); */


        }
        if(ProductToy != null)
        {
            ProductToy.GetComponent<move>().dropToy();
            tS.CompareToy();
            /*  identity = ProductToy.GetComponent<move>().identity;
              //goalToy = t;
              //Debug.Log("GOAAAAAALTOYYYYYYYYYy" + goalToy);
              if (identity == goalToy)
              {
                  Debug.Log("Correct!");
                  //ToySpawner.GetComponent<ToySpawner>().SpawnerToy();
                  tS.SpawnerToy();
              }
              else Destroy(ProductToy); */

        }
    }
}


/*Spawn = toy and box are correct
  Destroy when any of the box or toy is wrong(user ko chance dena hai ki sahi banaye)
 */