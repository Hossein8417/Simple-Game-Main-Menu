using UnityEngine;

public class MainMenu : IState
{
    
    private UIManager Manager;
    
    public MainMenu(UIManager manager)
    {
        Manager = manager;  
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from main menu");
            return;
        }
        Manager.refrences.MainMenuPanel.gameObject.SetActive(true);
        Manager.refrences.MainMenuPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        CheckInput();
        Manager.refrences.StoryButton.onClick.AddListener(OnStoryButtonPressed);
        Manager.refrences.ExtrasButton.onClick.AddListener(OnExtrasButtonPressed);
        Manager.refrences.OptionsButton.onClick.AddListener(OnOptionsButtonPressed);
        Manager.refrences.QuitDesktopButton.onClick.AddListener(OnQuitButtonPressed);
    }
    public void Hide()
    {
        Manager.refrences.MainMenuPanel.alpha = 0f;
        Manager.refrences.MainMenuPanel.gameObject.SetActive(false);
    }

    public void CheckInput() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Manager.ChangeState(Manager.quitMenu);
        }
    }
    public void OnStoryButtonPressed() {
        Manager.ChangeState(Manager.storyMenu);
    }
    public void OnExtrasButtonPressed() {
        Manager.ChangeState(Manager.extrasMenu);
    }
    public void OnOptionsButtonPressed()
    {
        Manager.ChangeState(Manager.optionsMenu);
    }
    public void OnQuitButtonPressed()
    {
        Manager.ChangeState(Manager.quitMenu);
    }
}