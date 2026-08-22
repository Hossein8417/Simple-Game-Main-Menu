using UnityEngine;

public class OptionsMenu : IState
{
    private UIManager Manager;
    public OptionsMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Options menu");
            return;
        }
        Manager.panelsController.PanelActiver(Manager.refrences.OptionsPanel, true);
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.panelsController.PanelActiver(Manager.refrences.OptionsPanel, false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}