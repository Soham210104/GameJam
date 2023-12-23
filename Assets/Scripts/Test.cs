using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Test : MonoBehaviour
{

   
        public static Test Instance;
        public GameObject boxSpawner,toySpawner;
        public string prefabNameBox;
        public string prefabNameToy;
        public bool boxCorrect;
        public bool toyCorrect;
        public TextMeshProUGUI scoreText;
        public int score = 0;
    
    void Awake()
        {
            boxCorrect = false;
            toyCorrect = false;
            if (Instance != null) { Destroy(gameObject); return; } // stops dups running
            DontDestroyOnLoad(gameObject); // keep me forever
            Instance = this; // set the reference to it
            boxSpawner.GetComponent<BoxSpawner>().Spawner();
            toySpawner.GetComponent<ToySpawner>().SpawnerToy();   
        }
    
}
/*
 1)Box and Toy will be displayed
    if user start from BoxRoom
 2)Box will be made if correct we have to drop but dont spawn the next box...if wrong then destroy
 3)Toy will be made if correct we have to drop and then destroy both and spawn new box and toy(correct order place)...if wrong then destroy
    VICE VERSA if user start from toyRoom!
 */