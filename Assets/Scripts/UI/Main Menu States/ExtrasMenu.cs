using UnityEngine;

public class ExtrasMenu : IState
{
    private UIManager Manager;   
    public ExtrasMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Extras menu");
            return;
        }
        Manager.panelsController.PanelActiver(Manager.refrences.ExtrasPanel, true);
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.panelsController.PanelActiver(Manager.refrences.ExtrasPanel, false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.registry.Get(States.MainMenu);
        }
    }
}