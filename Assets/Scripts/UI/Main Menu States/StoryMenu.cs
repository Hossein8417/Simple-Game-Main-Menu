using UnityEngine;

public class StoryMenu : IState
{
    private UIManager Manager;
    
    public StoryMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from story menu");
            return;
        }
        Manager.panelsController.PanelActiver(Manager.refrences.StoryPanel, true);
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.panelsController.PanelActiver(Manager.refrences.StoryPanel, false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.registry.Get(States.MainMenu);
        }
    }
}
