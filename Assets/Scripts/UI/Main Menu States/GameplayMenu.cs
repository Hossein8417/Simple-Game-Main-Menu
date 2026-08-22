using UnityEngine;

public class GameplayMenu : IState
{
    private UIManager Manager;

    public GameplayMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Gameplay menu");
            return;
        }
        Manager.refrences.GameplayPanel.gameObject.SetActive(true);
        Manager.refrences.GameplayPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.GameplayPanel.alpha = 0f;
        Manager.refrences.GameplayPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}
