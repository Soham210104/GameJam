using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NewPlayerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb;
    [Range(2,10)] [SerializeField] 
    private float speed = 3.8f;
    private Animator animator;
    public GameObject machine1;
    public GameObject machine2;
    public GameObject machine3;

    public static NewPlayerMovement Instance;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0) {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else {
            animator.SetBool ("IsWalking", false);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    
    //void OnTriggerEnter2D(Collider2D c)
    //{
    //    if(c.tag == "DoorLeft")
    //    {
    //        SceneManager.LoadScene(1);
    //    }
    //    if (c.tag == "DoorRight")
    //    {
    //        SceneManager.LoadScene(2);
    //    }
    //    if(c.tag == "Trigger1")
    //    {
    //        machine1.SetActive(true);
    //    }
    //    if (c.tag == "Trigger2")
    //    {
    //        machine2.SetActive(true);
    //    }
    //    if (c.tag == "Trigger3")
    //    {
    //        machine3.SetActive(true);
    //    }
    //}

    //void OnTriggerExit2D(Collider2D c)
    //{
    //    if(c.tag == "Trigger1")
    //    {
    //        machine1.SetActive(false);
    //    }
    //    if (c.tag == "Trigger2")
    //    {
    //        machine2.SetActive(false);
    //    }
    //    if (c.tag == "Trigger3")
    //    {
    //        machine3.SetActive(false);
    //    }
    //}
}
