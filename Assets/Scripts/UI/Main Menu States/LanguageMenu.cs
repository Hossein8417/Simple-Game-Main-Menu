using UnityEngine;

public class LanguageMenu : IState
{

    private UIManager Manager;

    public LanguageMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Language menu");
            return;
        }
        Manager.refrences.LanguagePanel.gameObject.SetActive(true);
        Manager.refrences.LanguagePanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.LanguagePanel.alpha = 0f;
        Manager.refrences.LanguagePanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}