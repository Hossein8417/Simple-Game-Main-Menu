using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    #region Properties
    public EnterCanvasItems EnterCanvas { get; set; }
    public AdvancedGraphicsCanvas GraphicsCanvas { get; set; }
    public AudioCanvas AudioCanvas { get; set; }
    public ChapterSelectMenu ChapterSelectMenu { get; set; }
    public ControlsCanvas ControlsCanvas { get; set; }
    public DisplayCanvas DisplayCanvas { get; set; }
    public ExtrasCanvas ExtrasCanvas { get; set; }
    public GameplayCanvas GameplayCanvas { get; set; }
    public KeyBindingsCanvas KeyBindingsCanvas { get; set; }
    public LanguageCanvas LanguageCanvas { get; set; }
    public LoadGameMenu LoadGameMenu { get; set; }
    public MainMenuCanvas MainMenuCanvas { get; set; }
    public NewGameMenu NewGameMenu { get; set; }
    public OptionsCanvas OptionsCanvas { get; set; }
    public QuitCanvas QuitCanvas { get; set; }
    public StoryCanvas StoryCanvas { get; set; }
   

    #endregion
    public UI_Manager(EnterCanvasItems enterCanvas, AdvancedGraphicsCanvas graphicsCanvas, AudioCanvas audioCanvas, ChapterSelectMenu chapterSelectMenu, ControlsCanvas controlsCanvas, DisplayCanvas displayCanvas, ExtrasCanvas extrasCanvas, GameplayCanvas gameplayCanvas, KeyBindingsCanvas keyBindingsCanvas, LanguageCanvas languageCanvas, LoadGameMenu loadGameMenu, MainMenuCanvas mainMenuCanvas, NewGameMenu newGameMenu, OptionsCanvas optionsCanvas, QuitCanvas quitCanvas, StoryCanvas storyCanvas)
    {
        EnterCanvas = enterCanvas;
        GraphicsCanvas = graphicsCanvas;
        AudioCanvas = audioCanvas;
        ChapterSelectMenu = chapterSelectMenu;
        ControlsCanvas = controlsCanvas;
        DisplayCanvas = displayCanvas;
        ExtrasCanvas = extrasCanvas;
        GameplayCanvas = gameplayCanvas;
        KeyBindingsCanvas = keyBindingsCanvas;
        LanguageCanvas = languageCanvas;
        LoadGameMenu = loadGameMenu;
        MainMenuCanvas = mainMenuCanvas;
        NewGameMenu = newGameMenu;
        OptionsCanvas = optionsCanvas;
        QuitCanvas = quitCanvas;
        StoryCanvas = storyCanvas;
    }
}