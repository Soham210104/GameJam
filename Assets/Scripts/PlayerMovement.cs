using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement script
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, y, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "BoxDoor")
        {
            //Debug.Log("BoxDoor enter");
            SceneManager.LoadScene(1);
        }
        else if (col.gameObject.tag == "ToyDoor")
        {
            //Debug.Log("ToyDoor enter");
            SceneManager.LoadScene(2);
        }
    }
}
