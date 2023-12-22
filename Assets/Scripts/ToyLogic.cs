using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToyLogic : MonoBehaviour
{
    private Camera _mainCamera;
    public GameObject product;
    SpriteRenderer rnd;
    public string s, initSprite;
    public bool f1, f2, f3;
    public bool productAtPickUp;
    public Sprite[] spriteArray;
    //public Vector2 m2pos;
    //moveM1toM2 m1tom2;
    void Start()
    {
        product.SetActive(false);
        f1 = true;
        f2 = false;
        f3 = false;
        productAtPickUp = false;
        rnd = product.GetComponent<SpriteRenderer>();
        // .GetComponent<YourScriptName>.YourFunction()
        //m1tom2 = FindObjectOfType<moveM1toM2>();
        //moveit();
    }
    void Awake()
    {
        _mainCamera = Camera.main;
        s = "";
        initSprite = "";
    }
    //     public void moveit()
    //     {
    //         m1tom2.move();

    //     }
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;
        var selectedOption = rayHit.collider.gameObject.name;
        switch (selectedOption)
        {
            case "slot1":
                if (!f1) break;
                Debug.Log("slot1 Selected");
                product.SetActive(true);
                rnd.sprite = spriteArray[0];

                product.GetComponent<move>().moveM1toM2();
                s = "Be";
                initSprite = "Sq";
                //Invoke("DelayedFunction",2f);
                //productSquare.transform.Translate(Vector3.right * Time.deltaTime, Space.World);
                //moveit();

                f1 = false;
                f2 = true;
                break;
            case "slot2":
                if (!f1) break;
                Debug.Log("slot2 Selected");
                product.SetActive(true);
                rnd.sprite = spriteArray[1];
                product.GetComponent<move>().moveM1toM2();
                s = "El";
                initSprite = "Ci";
                f1 = false;
                f2 = true;
                break;
            case "slot3":
                if (!f1) break;
                Debug.Log("slot3 Selected");
                product.SetActive(true);
                rnd.sprite = spriteArray[2];
                product.GetComponent<move>().moveM1toM2();
                s = "Du";
                initSprite = "Ca";
                f1 = false;
                f2 = true;
                break;


            case "slot4":
                if (!f2) break;
                Debug.Log("slot4 Selected");
                if (s == "Be")
                    rnd.sprite = spriteArray[3];
                if (s == "El")
                    rnd.sprite = spriteArray[4];
                if (s == "Du")
                    rnd.sprite = spriteArray[5];
                product.GetComponent<move>().moveM2toM3();
                s += "Br";
                f2 = false;
                f3 = true;
                break;
            case "slot5":
                if (!f2) break;
                Debug.Log("slot5 Selected");
                if (s == "Be")
                    rnd.sprite = spriteArray[6];
                if (s == "El")
                    rnd.sprite = spriteArray[7];
                if (s == "Du")
                    rnd.sprite = spriteArray[8];
                //rnd.sprite = spriteArray[0];
                product.GetComponent<move>().moveM2toM3();
                s += "Ye";
                f2 = false;
                f3 = true;
                break;
            case "slot6":
                if (!f2) break;
                Debug.Log("slot6 Selected");
                if (s == "Be")
                    rnd.sprite = spriteArray[9];
                if (s == "El")
                    rnd.sprite = spriteArray[10];
                if (s == "Du")
                    rnd.sprite = spriteArray[11];
                //rnd.sprite = spriteArray[0];
                product.GetComponent<move>().moveM2toM3();
                s += "Bl";
                f2 = false;
                f3 = true;
                break;
            case "slot7":
                if (!f3) break;
                Debug.Log("slot7 Selected");
                if (s == "BeBr")
                    rnd.sprite = spriteArray[12];
                if (s == "BeYe")
                    rnd.sprite = spriteArray[13];
                if (s == "BeBl")
                    rnd.sprite = spriteArray[14];
                if (s == "ElBr")
                    rnd.sprite = spriteArray[15];
                if (s == "ElYe")
                    rnd.sprite = spriteArray[16];
                if (s == "ElBl")
                    rnd.sprite = spriteArray[17];
                if (s == "DuBr")
                    rnd.sprite = spriteArray[18];
                if (s == "DuYe")
                    rnd.sprite = spriteArray[19];
                if (s == "DuBl")
                    rnd.sprite = spriteArray[20];
                product.GetComponent<move>().moveM3toPickup();
                s += "Be";
                f3 = false;
                productAtPickUp = true;
                f1 = true;
                break;
            case "slot8":
                if (!f3) break;
                Debug.Log("slot8 Selected");
                //rnd.sprite = spriteArray[0];
                if (s == "BeBr")
                    rnd.sprite = spriteArray[21];
                if (s == "BeYe")
                    rnd.sprite = spriteArray[22];
                if (s == "BeBl")
                    rnd.sprite = spriteArray[23];
                if (s == "ElBr")
                    rnd.sprite = spriteArray[24];
                if (s == "ElYe")
                    rnd.sprite = spriteArray[25];
                if (s == "ElBl")
                    rnd.sprite = spriteArray[26];
                if (s == "DuBr")
                    rnd.sprite = spriteArray[27];
                if (s == "DuYe")
                    rnd.sprite = spriteArray[28];
                if (s == "DuBl")
                    rnd.sprite = spriteArray[29];
                product.GetComponent<move>().moveM3toPickup();
                s += "Cl";
                f3 = false;
                productAtPickUp = true;
                f1 = true;
                break;
            case "slot9":
                if (!f3) break;
                Debug.Log("slot9 Selected");
                //rnd.sprite = spriteArray[0];
                if (s == "BeBr")
                    rnd.sprite = spriteArray[30];
                if (s == "BeYe")
                    rnd.sprite = spriteArray[31];
                if (s == "BeBl")
                    rnd.sprite = spriteArray[32];
                if (s == "ElBr")
                    rnd.sprite = spriteArray[33];
                if (s == "ElYe")
                    rnd.sprite = spriteArray[34];
                if (s == "ElBl")
                    rnd.sprite = spriteArray[35];
                if (s == "DuBr")
                    rnd.sprite = spriteArray[36];
                if (s == "DuYe")
                    rnd.sprite = spriteArray[37];
                if (s == "DuBl")
                    rnd.sprite = spriteArray[38];
                product.GetComponent<move>().moveM3toPickup();
                s += "He";
                f3 = false;
                productAtPickUp = true;
                f1 = true;
                break;

        }
    }
}
