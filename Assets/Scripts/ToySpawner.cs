using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySpawner : MonoBehaviour
{
    public GameObject[] objects;
    public Transform spawnPoint;
    public string prefabName;
    // Start is called before the first frame update
    void Start()
    {
        if (objects.Length > 0)
        {
            int randomIndex = Random.Range(0, objects.Length);

            GameObject randomBox = Instantiate(objects[randomIndex], spawnPoint.position, Quaternion.identity);
            prefabName = randomBox.name;
            Debug.Log("Selected prefab name: " + prefabName);
        }
        else
        {
            Debug.LogError("No prefabs assigned to the  array in the BoxSpawner script.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
