using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Refrences
    public UIRefrences refrences;
    public Registry registry;
    #endregion

    #region
    IState currentState;
    #endregion

    #region States
    public EnterMenu enterMenu;
    public MainMenu mainMenu;
    public StoryMenu storyMenu;
    public NewGame newGame;
    public LoadGame loadGame;
    public ChapterSelect chapterSelect;
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
    #endregion

    #region Controllers
    public PanelsController panelsController;
    #endregion


    private void Awake()
    {   
        IntializeStates();
        InitialControllers();
        
    }

    private void Start()
    {
        InitialDefaultState();
    }

    private void Update()
    {
        currentState.UpdateState();
    }

    public void ChangeState(States newState)
    {
        currentState.Hide();
       
        currentState = registry.Get(newState);

        currentState.Show();
    }
    private void InitialControllers() {
        panelsController = GetComponent<PanelsController>();
    }
    private void IntializeStates() {
        enterMenu = new EnterMenu(this);
        mainMenu = new MainMenu(this);
        storyMenu = new StoryMenu(this);
        newGame = new NewGame(this);
        loadGame = new LoadGame(this);
        chapterSelect = new ChapterSelect(this);
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
    private void InitialDefaultState() {
        Debug.Log("Null from InitialDefaultState1");
        currentState = registry.Get(States.EnterMenu);
        Debug.Log("Null from InitialDefaultState2");
        currentState.Show();
    }
}