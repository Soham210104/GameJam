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
    Transform Player;
    [SerializeField] private string identity;
    [SerializeField] private Sprite[] spriteArrays;
    void Start()
    {
        PlayerG = GameObject.Find("Player");
        Player = PlayerG.GetComponent<Transform>();
        rnd = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(flag)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, Player.position,  50f*Time.deltaTime);
            transform.position = new Vector3(newPosition.x , newPosition.y+ 0.1f, transform.position.z);

            switch (identity) 
            {
                case "CyBlP1":
                    rnd.sprite = spriteArrays[0];
                    break;
                case "CyBlP2":
                    rnd.sprite = spriteArrays[1];
                    break;
                case "CyBlP3":
                    rnd.sprite = spriteArrays[2];
                    break;
                case "CyGrP1":
                    rnd.sprite = spriteArrays[3];
                    break;
                case "CyGrP2":
                    rnd.sprite = spriteArrays[4];
                    break;
                case "CyGrP3":
                    rnd.sprite = spriteArrays[5];
                    break;
                case "CyReP1":
                    rnd.sprite = spriteArrays[6];
                    break;
                case "CyReP2":
                    rnd.sprite = spriteArrays[7];
                    break;
                case "CyReP3":
                    rnd.sprite = spriteArrays[8];
                    break;
                case "LoBlP1":
                    rnd.sprite = spriteArrays[9];
                    break;
                case "LoBlP2":
                    rnd.sprite = spriteArrays[10];
                    break;
                case "LoBlP3":
                    rnd.sprite = spriteArrays[11];
                    break;
                case "LoGrP1":
                    rnd.sprite = spriteArrays[12];
                    break;
                case "LoGrP2":
                    rnd.sprite = spriteArrays[13];
                    break;
                case "LoGrP3":
                    rnd.sprite = spriteArrays[14];
                    break;
                case "LoReP1":
                    rnd.sprite = spriteArrays[15];
                    break;
                case "LoReP2":
                    rnd.sprite = spriteArrays[16];
                    break;
                case "LoReP3":
                    rnd.sprite = spriteArrays[17];
                    break;
                case "SqBlP1":
                    rnd.sprite = spriteArrays[18];
                    break;
                case "SqBlP2":
                    rnd.sprite = spriteArrays[19];
                    break;
                case "SqBlP3":
                    rnd.sprite = spriteArrays[20];
                    break;
                case "SqGrP1":
                    rnd.sprite = spriteArrays[21];
                    break;
                case "SqGrP2":
                    rnd.sprite = spriteArrays[22];
                    break;
                case "SqGrP3":
                    rnd.sprite = spriteArrays[23];
                    break;
                case "SqReP1":
                    rnd.sprite = spriteArrays[24];
                    break;
                case "SqReP2":
                    rnd.sprite = spriteArrays[25];
                    break;
                case "SqReP3":
                    rnd.sprite = spriteArrays[26];
                    break;
            }
              
                
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
        // This object should be child of Player
    }

    public void dropBox()
    {
        flag = false;
        transform.position = new Vector2(-0.23f, -3.45f);
    }
    public void dropToy()
    {
        flag = false;
        transform.position = new Vector2(1.15f, -3.45f);
    }
}
