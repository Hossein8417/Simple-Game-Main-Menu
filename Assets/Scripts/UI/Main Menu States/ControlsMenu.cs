using UnityEngine;

public class ControlsMenu : IState
{
    private UIManager Manager;

    public ControlsMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Controls menu");
            return;
        }
        Manager.refrences.ControlsPanel.gameObject.SetActive(true);
        Manager.refrences.ControlsPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.ControlsPanel.alpha = 0f;
        Manager.refrences.ControlsPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}