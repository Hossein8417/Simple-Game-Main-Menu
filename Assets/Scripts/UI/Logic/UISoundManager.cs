using UnityEngine;

public class UISoundManager : MonoBehaviour
{
    public static UISoundManager Instance;


    private void Awake()
    {
        if (Instance == null) { 
            Instance = this;
        }
        if (Instance != null) { 
            DontDestroyOnLoad(gameObject);
        }
    }

    [SerializeField]
    private AudioSource clickSound;
    public void UIClick() {
        clickSound.Play();
    }
}