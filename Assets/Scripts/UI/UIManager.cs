using UnityEngine;

public class UIManager : MonoBehaviour
{
    //refrences
    public UIRefrences refrences;

    //instances
    IState currentState;

    //states refrences
    public EnterMenu enterMenu;
    public MainMenu mainMenu;
    public StoryMenu storyMenu;
    public ExtrasMenu extrasMenu;
    public OptionsMenu optionsMenu;
    public QuitMenu quitMenu;
    public GameplayMenu gameplayMenu;
    public ControlsMenu controlsMenu;
    public KeyBindingsMenu keyBindingsMenu;
    public DisplayMenu displayMenu;
    public AdvancedGraphicsMenu advancedGraphicsMenu;
    public AudioMenu audioMenu;
    public LanguageMenu languageMenu;


    private void Awake()
    {
        IntializeStates();
    }

    private void Start()
    {
        currentState = enterMenu;
        currentState.Show();
    }

    private void Update()
    {
        currentState.UpdateState();
    }

    public void ChangeState(IState newState) {
        currentState.Hide();
        
        currentState = newState;

        currentState.Show();
    }

    public void IntializeStates() {
        enterMenu = new EnterMenu(this);
        mainMenu = new MainMenu(this);
        storyMenu = new StoryMenu(this);
        extrasMenu = new ExtrasMenu(this);
        optionsMenu = new OptionsMenu(this);
        quitMenu = new QuitMenu(this);
        gameplayMenu = new GameplayMenu(this);
        controlsMenu = new ControlsMenu(this);
        keyBindingsMenu = new KeyBindingsMenu(this);
        displayMenu = new DisplayMenu(this);
        advancedGraphicsMenu = new AdvancedGraphicsMenu(this);
        audioMenu = new AudioMenu(this);
        languageMenu = new LanguageMenu(this);
    }
}