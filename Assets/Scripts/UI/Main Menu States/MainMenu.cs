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
        Manager.panelsController.PanelActiver(Manager.refrences.MainMenuPanel, true);
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
        Manager.panelsController.PanelActiver(Manager.refrences.MainMenuPanel, false);
    }

    public void CheckInput() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Manager.registry.Get(States.QuitMenu);
        }
    }
    public void OnStoryButtonPressed() {
        Manager.registry.Get(States.StoryMenu);
    }
    public void OnExtrasButtonPressed() {
        Manager.registry.Get(States.Extrasmenu);
    }
    public void OnOptionsButtonPressed()
    {
        Manager.registry.Get(States.OptionsMenu);
    }
    public void OnQuitButtonPressed()
    {
        Manager.registry.Get(States.QuitMenu);
    }
}