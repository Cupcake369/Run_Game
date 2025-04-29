using UnityEngine;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;
    [Header("-----Audio clip-----")]
    public AudioClip background;
    public AudioClip deathSound;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    
    public void playSFX(AudioClip deathSound)
    {
        sfxSource.PlayOneShot(deathSound);
    }
}
