using UnityEngine;

public class EnterMenu : IState
{
    private UIManager Manager;

    public EnterMenu(UIManager manager)
    {
        Manager = manager;
    }
    public void Show() {
        if (Manager == null) {
            Debug.LogError("Can't access to ui manager from enter menu");
            return;
        }
        Manager.refrences.EnterMenuPanel.gameObject.SetActive(true);
        Manager.refrences.EnterMenuPanel.alpha = 1f;
    }
    public void UpdateState() {
        CheckInput();
    }
    public void Hide() {
        Manager.refrences.EnterMenuPanel.alpha = 0f;
        Manager.refrences.EnterMenuPanel.gameObject.SetActive(false);
    }
    public void CheckInput() {
        if (Input.anyKeyDown)
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}