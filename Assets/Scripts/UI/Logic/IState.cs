public interface IState
{
    void Show(UIManager manager);
    void UpdateState(UIManager manager);
    void Hide(UIManager manager);
}