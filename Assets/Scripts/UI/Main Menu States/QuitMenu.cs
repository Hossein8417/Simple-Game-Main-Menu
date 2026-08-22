using UnityEngine;

public class QuitMenu : IState
{
    private UIManager Manager;
    public QuitMenu(UIManager manager)
    {
        Manager = manager;
    }
    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Quit menu");
            return;
        }
        Manager.refrences.QuitPanel.gameObject.SetActive(true);
        Manager.refrences.QuitPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        Manager.refrences.YesButton.onClick.AddListener(OnQuitButtonClicked);
        Manager.refrences.NoButton.onClick.AddListener(OnQuitButtonNotClicked);
    }
    public void Hide()
    {
        Manager.refrences.QuitPanel.alpha = 0f;
        Manager.refrences.QuitPanel.gameObject.SetActive(false);
    }

    public void OnQuitButtonClicked() { 
        Application.Quit();
    }
    public void OnQuitButtonNotClicked() {
        Manager.ChangeState(Manager.mainMenu);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}
