using UnityEngine;

public class MusicToggler : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isMusicPlaying = true;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check if the player pressed the "M" key
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Toggle the music on or off
            if (isMusicPlaying)
            {
                // Pause the music
                audioSource.Pause();
            }
            else
            {
                // Resume playing the music
                audioSource.Play();
            }

            // Toggle the flag
            isMusicPlaying = !isMusicPlaying;
        }
    }
}
