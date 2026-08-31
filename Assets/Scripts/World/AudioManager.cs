using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource.Play();
    }

    private void OnDestroy()
    {
        audioSource.Stop();

    }
}