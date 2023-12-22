using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySpawner : MonoBehaviour
{
    public GameObject[] objects;
    public Transform spawnPoint;
    public string prefabName,identity;
    public GameObject randomBox;
    public move m;
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
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnerToy()
    {
        int randomIndex = Random.Range(0, objects.Length);
        randomBox = Instantiate(objects[randomIndex], spawnPoint.position, Quaternion.identity);
        DontDestroyOnLoad(randomBox);
        prefabName = randomBox.name;
        prefabName = prefabName.Replace("(Clone)", "");
        Debug.Log("Selected prefab name: " + prefabName);
    }

    public void CompareToy()
    {
        if (identity.Length != 0 && prefabName.Length != 0)
        //NOT WORKINGGGGGgg
        {
            if (identity == prefabName)
            {
                Debug.Log("A");
                m.dropToy();
            }
            else
            {
                Debug.Log("B");
                Destroy(m.gameObject);
            }
        }
    }
}
