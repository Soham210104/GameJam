using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector2 m2pos,m3pos,pickupPos; // Replace with your desired coordinates

    public Transform Player;
    bool flag = false;
    public float moveSpeed = 5f;
    [SerializeField] private string identity;

    void Update()
    {
        if(flag)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, Player.position,  50f*Time.deltaTime);

           
            transform.position = new Vector3(newPosition.x , newPosition.y+ 0.1f, transform.position.z);

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

        // This object should be child of Player
    }
}
