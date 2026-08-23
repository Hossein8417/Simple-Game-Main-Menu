using UnityEngine;

public class ChapterSelect : IState
{
    private UIManager Manager;

    public ChapterSelect(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from ChapterSelect menu");
            return;
        }
        Manager.panelsController.PanelActiver(Manager.refrences.ChapterSelectPanel, true);
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.panelsController.PanelActiver(Manager.refrences.ChapterSelectPanel, false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.registry.Get(States.StoryMenu);
        }
    }
}
