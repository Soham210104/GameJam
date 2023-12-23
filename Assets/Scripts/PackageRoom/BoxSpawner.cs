using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objects;
    public Transform spawnPoint;
    public string prefabName;
    public GameObject randomBox;
    public static bool flag = false;
    public string identity;
    public Test test;
    public ToySpawner t;
    public move m;
    void Start()
    {
        /*
        if(!flag)
        {
            Spawner();
        } */
        m = GameObject.FindWithTag("Product").GetComponent<move>();
        identity = m.identity;
        test = GameObject.FindWithTag("Test").GetComponent<Test>();
    }

    void Update()
    {
        
    }


    public void Spawner()
    {
        GameObject existingBox = GameObject.FindWithTag("Box");
        if (existingBox != null)
        {
            Destroy(existingBox);
        }
        //Destroy(GameObject.FindWithTag("Box"));
        int randomIndex = Random.Range(0, objects.Length);
            randomBox = Instantiate(objects[randomIndex], spawnPoint.position, Quaternion.identity);
            DontDestroyOnLoad(randomBox);
            prefabName = randomBox.name;
            prefabName = prefabName.Replace("(Clone)", "");
            Debug.Log("Selected prefab name: " + prefabName);
            test.prefabNameBox = prefabName;
            Debug.Log("TESTTTTT PREFABBB" +  test.prefabNameBox);
    }
    public void CompareBox()
    {
        if (identity.Length != 0 && test.prefabNameBox.Length != 0)
            Debug.Log("COMPARE BOX FUNCTIONNNNNNNNNNN");
            //NOT WORKINGGGGGgg
        {
            if (identity == test.prefabNameBox)
            {
                test.boxCorrect = true;
                Debug.Log("A");
                m.dropBox();
                if(test.boxCorrect == true && test.toyCorrect == true)
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
                    Spawner();
                    t.SpawnerToy();
                    test.boxCorrect = false;
                    test.toyCorrect = false;
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

/*
 GameObject saved->goal string saved->until drop->when drop and correct->run random function
 Box made->if correct place in table or destroy->go for toy production->if toy correct place in table whole compare->if toy wrong destroy.
 */