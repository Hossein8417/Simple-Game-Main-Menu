using UnityEngine;

public class AudioMenu : IState
{
    private UIManager Manager;

    public AudioMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Audio menu");
            return;
        }
        Manager.refrences.AudioPanel.gameObject.SetActive(true);
        Manager.refrences.AudioPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.AudioPanel.alpha = 0f;
        Manager.refrences.AudioPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}
