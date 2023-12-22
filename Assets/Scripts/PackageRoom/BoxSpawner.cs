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
    }

    void Update()
    {
        
    }


    public void Spawner()
    {
        //Destroy(GameObject.FindWithTag("Box"));
        int randomIndex = Random.Range(0, objects.Length);
        randomBox = Instantiate(objects[randomIndex], spawnPoint.position, Quaternion.identity);
        DontDestroyOnLoad(randomBox);
        prefabName = randomBox.name;
        prefabName = prefabName.Replace("(Clone)", "");
        Debug.Log("Selected prefab name: " + prefabName);
    }
    public void CompareBox()
    {
        if (identity.Length != 0 && prefabName.Length != 0)
        //NOT WORKINGGGGGgg
        {
            if (identity == prefabName)
            {
                Debug.Log("A");
                m.dropBox();
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