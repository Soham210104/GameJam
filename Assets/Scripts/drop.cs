using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.PlayerPrefs;
public class drop : MonoBehaviour
{
    public GameObject Product;
    public GameObject ProductToy;
    //public GameObject BoxSpawner,ToySpawner;
    public BoxSpawner bS;
    public ToySpawner tS;
    //public GameObject BoxSpawner,
    //public string b, t;
    //public string identity;
    [SerializeField] private string goalBox,goalToy;
    // Start is called before the first frame update
    void Start()
    {
        bS = GameObject.FindWithTag("BoxSpawner").GetComponent<BoxSpawner>();
        tS = GameObject.FindWithTag("ToySpawner").GetComponent<ToySpawner>();
        goalBox = bS.prefabName;
        goalToy = tS.prefabName;
        Debug.Log("goalBox is" + goalBox);
        Debug.Log("goalToy is" + goalToy);
        Product = GameObject.FindWithTag("Product");
        ProductToy = GameObject.FindWithTag("ProductToy");
    }
   /* void OnEnable()
    {
        goalBox = GetString("goalBox", "");
        goalToy = GetString("goalToy", "");
        Debug.Log("Retrieved values: goalBox = " + goalBox + ", goalToy = " + goalToy);
    }
    void OnDisable()
    {
        // Store goalBox and goalToy values in PlayerPrefs before scene reload
       SetString("goalBox", goalBox);
       SetString("goalToy", goalToy);
       Debug.Log("Saved values: goalBox = " + goalBox + ", goalToy = " + goalToy);
    } */
    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Product != null)
        {
            Product.GetComponent<move>().dropBox();
            Debug.Log("ON COLLISION FUNCTION BOXXXXXXXX");
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
            Debug.Log("On COllision Function Toyyyyy");
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

/*
 Drop has identity of the box that has been displayed
 */