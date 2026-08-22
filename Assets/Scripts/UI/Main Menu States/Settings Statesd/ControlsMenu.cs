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
        Manager.panelsController.PanelActiver(Manager.refrences.ControlsPanel, true);
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.panelsController.PanelActiver(Manager.refrences.ControlsPanel, false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}