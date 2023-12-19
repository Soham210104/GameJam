using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Logic : MonoBehaviour
{
    private Camera _mainCamera;
    public GameObject productSquare, productCircle, productCapsule;
    public string s, initSprite;
    public bool f1, f2, f3;
    public bool productAtPickUp;
    //public Vector2 m2pos;
    //moveM1toM2 m1tom2;
    void Start()
    {
        productSquare.SetActive(false);
        productCircle.SetActive(false);
        productCapsule.SetActive(false);
        f1 = true;
        f2 = false;
        f3 = false;
        productAtPickUp = false;
        // .GetComponent<YourScriptName>.YourFunction()
        //m1tom2 = FindObjectOfType<moveM1toM2>();
        //moveit();
    }
    private void Awake()
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
        Debug.Log(rayHit.collider.gameObject.name);
        switch (selectedOption)
        {
            case "Option1M1":
                if (!f1) break;
                Debug.Log("Option1M1 Selected");
                productSquare.SetActive(true);
                productSquare.GetComponent<move>().moveM1toM2();
                s = "Sq";
                initSprite = "Sq";
                //Invoke("DelayedFunction",2f);
                //productSquare.transform.Translate(Vector3.right * Time.deltaTime, Space.World);
                //moveit();

                f1 = false;
                f2 = true;
                break;
            case "Option2M1":
                if (!f1) break;
                Debug.Log("Option2M1 Selected");
                productCircle.SetActive(true);
                productCircle.GetComponent<move>().moveM1toM2();
                s = "Ci";
                initSprite = "Ci";
                f1 = false;
                f2 = true;
                break;
            case "Option3M1":
                if (!f1) break;
                Debug.Log("Option3M1 Selected");
                productCapsule.SetActive(true);
                productCapsule.GetComponent<move>().moveM1toM2();
                s = "Ca";
                initSprite = "Ca";
                f1 = false;
                f2 = true;
                break;
            case "Option1M2":
                if (!f2) break;
                Debug.Log("Option1M2 Selected");
                if (initSprite == "Sq") productSquare.GetComponent<move>().moveM2toM3();
                else if (initSprite == "Ci") productCircle.GetComponent<move>().moveM2toM3();
                else productCapsule.GetComponent<move>().moveM2toM3();
                s += "11";
                f2 = false;
                f3 = true;
                break;
            case "Option2M2":
                if (!f2) break;
                Debug.Log("Option2M2 Selected");
                if (initSprite == "Sq") productSquare.GetComponent<move>().moveM2toM3();
                else if (initSprite == "Ci") productCircle.GetComponent<move>().moveM2toM3();
                else productCapsule.GetComponent<move>().moveM2toM3();
                s += "22";
                f2 = false;
                f3 = true;
                break;
            case "Option3M2":
                if (!f2) break;
                Debug.Log("Option3M2 Selected");
                if (initSprite == "Sq") productSquare.GetComponent<move>().moveM2toM3();
                else if (initSprite == "Ci") productCircle.GetComponent<move>().moveM2toM3();
                else productCapsule.GetComponent<move>().moveM2toM3();
                s += "33";
                f2 = false;
                f3 = true;
                break;
            case "Option1M3":
                if (!f3) break;
                Debug.Log("Option1M3 Selected");
                if (initSprite == "Sq") productSquare.GetComponent<move>().moveM3toPickup();
                else if (initSprite == "Ci") productCircle.GetComponent<move>().moveM3toPickup();
                else productCapsule.GetComponent<move>().moveM3toPickup();
                s += "XX";
                f3 = false;
                productAtPickUp = true;
                break;
            case "Option2M3":
                if (!f3) break;
                Debug.Log("Option2M3 Selected");
                if (initSprite == "Sq") productSquare.GetComponent<move>().moveM3toPickup();
                else if (initSprite == "Ci") productCircle.GetComponent<move>().moveM3toPickup();
                else productCapsule.GetComponent<move>().moveM3toPickup();
                s += "YY";
                f3 = false;
                productAtPickUp = true;
                break;
            case "Option3M3":
                if (!f3) break;
                Debug.Log("Option3M3 Selected");
                if (initSprite == "Sq") productSquare.GetComponent<move>().moveM3toPickup();
                else if (initSprite == "Ci") productCircle.GetComponent<move>().moveM3toPickup();
                else productCapsule.GetComponent<move>().moveM3toPickup();
                s += "ZZ";
                f3 = false;
                productAtPickUp = true;
                break;

        }



    }
}
