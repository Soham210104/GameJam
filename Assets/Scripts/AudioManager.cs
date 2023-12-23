using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source -----")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("-----Audio Clips-----")]
    public AudioClip mainMenu;
    public AudioClip backgroundGame;
    public AudioClip machine1;
    public AudioClip machine2;
    public AudioClip machine3;
    public AudioClip machine4;

    public AudioClip success;
    public AudioClip failure;

    private static AudioManager instance;
    private Scene currentScene;

    private void Awake()
    {
        // Ensure only one instance of AudioManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        currentScene = SceneManager.GetActiveScene();

        // Check the current scene and play the appropriate audio clip
        if (currentScene.name == "MainMenu")
        {
            PlayMusic(mainMenu);
        }
        else
        {
            PlayMusic(backgroundGame);
        }
    }

    private void PlayMusic(AudioClip clip)
    {
        // Check if the audio clip is already playing to avoid restarting it
        if (!musicSource.isPlaying || musicSource.clip != clip)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
