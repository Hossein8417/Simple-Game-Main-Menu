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
        Manager.refrences.OptionsPanel.gameObject.SetActive(true);
        Manager.refrences.OptionsPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.OptionsPanel.alpha = 0f;
        Manager.refrences.OptionsPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}