using UnityEngine;

public class DisplayMenu : IState
{
    private UIManager Manager;

    public DisplayMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Display menu");
            return;
        }
        Manager.refrences.DisplayPanel.gameObject.SetActive(true);
        Manager.refrences.DisplayPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.DisplayPanel.alpha = 0f;
        Manager.refrences.DisplayPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}