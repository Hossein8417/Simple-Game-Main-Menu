using UnityEngine;

public class MainMenu : MonoBehaviour , IState
{
    [SerializeField]
    private UI_Manager manager;

    [SerializeField]
    private UIRefrences refrences;

    public MainMenu()
    {
        //Make refrences and set values
    }


    public void UpdateState()
    {
        //logic
    }



    public void Show()
    {
        refrences.MainMenuCanvas.MainMenuPanel.SetActive(true);
    }



    public void Hide()
    {
        refrences.MainMenuCanvas.MainMenuPanel.SetActive(false);
    }

}