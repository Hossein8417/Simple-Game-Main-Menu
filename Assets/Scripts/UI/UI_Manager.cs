using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    private StateMachine stateMachine;

    private EnterMainMenu enterState;
    private MainMenu mainMenuState;


    private void Start()
    {
        stateMachine = new StateMachine();

        enterState = new EnterMainMenu();
        mainMenuState = new MainMenu();


        stateMachine.ChangeState(enterState);
    }


    private void Update()
    {
        if (stateMachine != null) {

            stateMachine.Update();


            HandleStateTransitions();

        }
    }

    private void HandleStateTransitions() { 
        //changeing logic

    }

}