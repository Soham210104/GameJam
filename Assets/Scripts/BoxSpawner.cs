using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] box;
    public Transform spawnPoint;

    void Start()
    {

        if (box.Length > 0)
        {
            int randomIndex = Random.Range(0, box.Length);

            GameObject randomBox = Instantiate(box[randomIndex], spawnPoint.position, Quaternion.identity);

        }
        else
        {
            Debug.LogError("No prefabs assigned to the 'box' array in the BoxSpawner script.");
        }
    }

    void Update()
    {

    }
}
