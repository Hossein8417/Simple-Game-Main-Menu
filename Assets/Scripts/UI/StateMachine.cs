
public class StateMachine
{
    private IState currentState;

    public void ChangeState(IState newState)
    {
        if (currentState != null)
        {

            currentState.Hide();
        }

        currentState = newState;


        currentState.Show();
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState();
        }
    }

}