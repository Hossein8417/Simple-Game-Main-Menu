using UnityEngine;

public class AdvancedGraphicsMenu : IState
{
    private UIManager Manager;

    public AdvancedGraphicsMenu(UIManager manager)
    {
        Manager = manager;
    }

    public void Show()
    {
        if (Manager == null)
        {
            Debug.LogError("Cant access to ui manager from Graphics menu");
            return;
        }
        Manager.refrences.GraphicsPanel.gameObject.SetActive(true);
        Manager.refrences.GraphicsPanel.alpha = 1f;
    }
    public void UpdateState()
    {
        //other logics
        CheckInput();
    }
    public void Hide()
    {
        Manager.refrences.GraphicsPanel.alpha = 0f;
        Manager.refrences.GraphicsPanel.gameObject.SetActive(false);
    }
    public void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Manager.ChangeState(Manager.mainMenu);
        }
    }
}
