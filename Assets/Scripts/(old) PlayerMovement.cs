using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input values
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        movement.Normalize(); // Ensure diagonal movement isn't faster

        // Move the player
        rb.velocity = movement * speed;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BoxDoor")
        {
            SceneManager.LoadScene(1);
        }
        else if (col.gameObject.tag == "ToyDoor")
        {
            SceneManager.LoadScene(2);
        }
    }
}
