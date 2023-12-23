using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
