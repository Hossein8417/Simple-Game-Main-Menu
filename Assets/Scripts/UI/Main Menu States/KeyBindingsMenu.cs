using UnityEngine;

public class KeyBindingsMenu : IState
{
    private UIManager Manager;

    public KeyBindingsMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Key Bindings menu");
            return;
        }
        Manager.refrences.keyBindingsPanel.gameObject.SetActive(true);
        Manager.refrences.keyBindingsPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.keyBindingsPanel.alpha = 0f;
        Manager.refrences.keyBindingsPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}
