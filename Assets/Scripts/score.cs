using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public Test test;
    public TextMeshProUGUI scoreText;

    
    void Start()
    {
        test = GameObject.Find("Test").GetComponent<Test>();
        if (test == null)
        {
            Debug.LogError("Test script reference not set in the inspector!");
        }

        
        scoreText = GetComponent<TextMeshProUGUI>();

        
        if (scoreText == null)
        {
            Debug.LogError("TextMeshProUGUI component not found on this GameObject!");
        }
    }

    
    void Update()
    {
        
        if (test != null && scoreText != null)
        {
            
            scoreText.text = test.score.ToString();
        }
        else
        {
            Debug.LogError("Test script or TextMeshProUGUI component reference is null!");
        }
    }
}
