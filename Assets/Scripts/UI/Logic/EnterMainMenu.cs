using System;
using UnityEngine;

public class EnterMainMenu : MonoBehaviour , IState
{

    [SerializeField]
    private UI_Manager manager;

    [SerializeField]
    private UIRefrences refrences;



    public EnterMainMenu()
    {
        //Make refrences and set values
    }



    public void UpdateState()
    {
        if (refrences != null)
        {
            if (Input.anyKeyDown)
            {
                //next state

                Debug.Log("Entered!");
                //Hide();
            }

        }
        if (refrences == null)
        {

            Debug.Log("manager is Empty");

        }
        //check if current state != this state => Hide();
    }

    public void Show()
    {
        refrences.EnterCanvas.EnterMenuPanel.SetActive(true);
    }

    public void Hide()
    {
        refrences.EnterCanvas.EnterMenuPanel.SetActive(false);
    }
}