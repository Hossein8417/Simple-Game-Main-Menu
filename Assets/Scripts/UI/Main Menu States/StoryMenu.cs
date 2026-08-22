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
        Manager.refrences.StoryPanel.gameObject.SetActive(true);
        Manager.refrences.StoryPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.StoryPanel.alpha = 0f;
        Manager.refrences.StoryPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}
