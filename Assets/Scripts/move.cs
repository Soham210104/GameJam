using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;
public class move : MonoBehaviour
{
    public Vector2 m2pos,m3pos,pickupPos; // Replace with your desired coordinates

    public GameObject PlayerG;
    bool flag = false;
    public float moveSpeed = 5f;
    private SpriteRenderer rnd;
    public Transform Player;
    public string identity;
    public string goalBox, goalToy;
    public GameObject BoxSpawner, ToySpawner;
    public GameObject respawning;
    //public Sprite[] spriteArrays;
    void Start()
    {
        PlayerG = GameObject.Find("Player");
        Player = PlayerG.GetComponent<Transform>();
        rnd = GetComponent<SpriteRenderer>();
        goalBox = BoxSpawner.GetComponent<BoxSpawner>().prefabName;
        
    }
    void LateUpdate()
    {
        if (flag)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, Player.position,  50f);
            transform.position = new Vector3(newPosition.x+0.5f , newPosition.y+ 0.6f, transform.position.z);
        }
    }
    public void moveM1toM2()
    {
        StartCoroutine(MoveObject(m2pos, moveSpeed));
    }
    public void moveM2toM3()
    {
        StartCoroutine(MoveObject(m3pos, moveSpeed));
    }
    public void moveM3toPickup()
    {
        StartCoroutine(MoveObject(pickupPos, moveSpeed));
    }

    IEnumerator MoveObject( Vector2 targetPos, float speed)
    {
        float t = 0f;
        Vector2 currentPos = transform.position;

        while (t < 1f)
        {
            t += Time.deltaTime * speed*0.1f;

            // Lerp (Linear Interpolation) to smoothly move the object
            transform.position = Vector2.Lerp(currentPos, targetPos, t);

            yield return null;
        }

        // Ensure the object reaches exactly at the target position
        transform.position = targetPos;
    }
   
    public void Follow(string s)
    {
        flag = true;
        identity = s;
        transform.SetParent(PlayerG.transform);
        GameObject newSpawned = Instantiate(respawning);
        // This object should be child of Player
    }

    public void dropBox()
    {
        flag = false;
        transform.position = new Vector2(-0.45f, -3.6f);
        transform.SetParent(null);
        if (identity == goalBox) Debug.Log("Correct!");
        else Destroy(gameObject);
    }
    public void dropToy()
    {
        flag = false;
        transform.position = new Vector2(1.52f, -3.6f);
        transform.SetParent(null);
        if (identity == goalToy) Debug.Log("Correct!");
        else Destroy(gameObject);
    }
}