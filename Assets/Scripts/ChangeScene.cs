using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string changeToSceneName;
    [SerializeField] private SceneInfo sceneInfo; // Reference to your SceneInfo ScriptableObject

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // Set the SceneInfo before loading the next scene
            SetSceneInfo();
            SceneManager.LoadScene(changeToSceneName);
        }
    }

    private void SetSceneInfo()
    {
        // Access the singleton instance of your player script
        NewPlayerMovement playerMovement = NewPlayerMovement.Instance;

        // Check if the playerMovement instance exists
        if (playerMovement != null)
        {
            // Set the SceneInfo in the playerMovement
            SceneInfo currentSceneInfo = playerMovement.GetSceneInfo();
            if (currentSceneInfo != null)
            {
                currentSceneInfo.isNextScene = true; // or set the value based on your needs
            }
        }
    }
}
