using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    private void Awake()
    {
        manager.refrences.Slot1NewGameButton.onClick.AddListener(OnSlot1Clicked);
        manager.refrences.Slot2NewGameButton.onClick.AddListener(OnSlot2Clicked);
        manager.refrences.Slot3NewGameButton.onClick.AddListener(OnSlot3Clicked);
        //load game slot 1 
        //load game slot 2 
        //load game slot 3
    }

    private void OnSlot1Clicked() {
        Debug.Log("Data saved to slot 1");
        SceneManager.LoadScene("Game");

    }
    private void OnSlot2Clicked()
    {
        Debug.Log("Data saved to slot 2");
        SceneManager.LoadScene("Game");

    }
    private void OnSlot3Clicked()
    {
        Debug.Log("Data saved to slot 3");
        SceneManager.LoadScene("Game");

    }
}