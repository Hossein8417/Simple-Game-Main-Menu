using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Refrences
    public UIRefrences refrences;
    #endregion

    #region Instances
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

    public void ChangeState(IState newState) {
        currentState.Hide();
        
        currentState = newState;

        currentState.Show();
    }
    public void InitialControllers() {
        panelsController = GetComponent<PanelsController>();
    }
    public void IntializeStates() {
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
    public void InitialDefaultState() {
        currentState = enterMenu;
        currentState.Show();
    }
}