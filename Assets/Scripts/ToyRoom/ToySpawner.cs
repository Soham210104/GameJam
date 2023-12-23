using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySpawner : MonoBehaviour
{
    public GameObject[] objects;
    public Transform spawnPoint;
    public string prefabName;
    public string identity;
    public GameObject randomBox;
    public BoxSpawner b;
    public move m;
    public Test test;
    //private static bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        /*if (objects.Length > 0)
        {
            int randomIndex = Random.Range(0, objects.Length);
            randomBox = Instantiate(objects[randomIndex], spawnPoint.position, Quaternion.identity);
            prefabName = randomBox.name;
            Debug.Log("Selected prefab name: " + prefabName);
        }
        else
        {
            Debug.LogError("No prefabs assigned to the  array in the BoxSpawner script.");
        }*/
        m = GameObject.FindWithTag("ProductToy").GetComponent<move>();
        identity = m.identity;
        test = GameObject.FindWithTag("Test").GetComponent<Test>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnerToy()
    {
        GameObject existingBox = GameObject.FindWithTag("Toy");
        if (existingBox != null)
        {
            Destroy(existingBox);
        }
        int randomIndex = Random.Range(0, objects.Length);
            randomBox = Instantiate(objects[randomIndex], spawnPoint.position, Quaternion.identity);
            DontDestroyOnLoad(randomBox);
            prefabName = randomBox.name;
            prefabName = prefabName.Replace("(Clone)", "");
            Debug.Log("Selected TOYYYYYYYYYY prefab name: " + prefabName);
            test.prefabNameToy = prefabName;
            Debug.Log("TOY NAMEEEEEEEEEEEEe " + test.prefabNameToy);
    }

    public void CompareToy()
    {
        if (identity.Length != 0 && test.prefabNameToy.Length != 0)
            //NOT WORKINGGGGGgg
            Debug.Log("COMPARE TOY FUNCTIONNNN");
        {
            if (identity == test.prefabNameToy)
            {
                test.toyCorrect = true;
                Debug.Log("A");
                m.dropToy();
                if (test.boxCorrect == true && test.toyCorrect == true)
                {
                    GameObject e = GameObject.FindWithTag("Product");
                    if (e != null)
                    {
                        Destroy(e);

                    }
                    GameObject e2 = GameObject.FindWithTag("ProductToy");
                    if (e2 != null)
                    {
                        Destroy(e2);
                    }
                    SpawnerToy();
                    b.Spawner();
                    test.toyCorrect = false;
                    test.boxCorrect = false;
                }
            }
            else
            {
                Debug.Log("B");
                Destroy(m.gameObject);
            }
        }
    }
}
