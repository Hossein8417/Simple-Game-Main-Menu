using System.Collections.Generic;
using UnityEngine;

public class Registry : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;
    public Dictionary<States, IState> states = new Dictionary<States, IState> ();

    private void Awake()
    {
        Debug.Log("Null from registry1");
        InitialStates();
        Debug.Log("Null from registry2");
    }

    private void InitialStates() {
        IState enterState = manager.enterMenu;
        IState mainState = manager.mainMenu;
        IState storyState = manager.storyMenu;
        IState optionsState = manager.optionsMenu;
        IState extrasState = manager.extrasMenu;
        IState quitState = manager.quitMenu;
        IState newGameState = manager.newGame;
        IState loadGameState = manager.loadGame;
        IState chapterSelectState = manager.chapterSelect;
        IState gameplayState = manager.gameplayMenu;
        IState controlsState = manager.controlsMenu;
        IState keyBindingsState = manager.keyBindingsMenu;
        IState displayState = manager.displayMenu;
        IState graphicsState = manager.advancedGraphicsMenu;
        IState audioState = manager.audioMenu;
        IState language = manager.languageMenu;

        states.Clear();
        states.Add(States.EnterMenu, enterState);
        states.Add(States.MainMenu, mainState);
        states.Add(States.StoryMenu, storyState);
        states.Add(States.OptionsMenu, optionsState);
        states.Add(States.Extrasmenu, extrasState);
        states.Add(States.QuitMenu, quitState);
        states.Add(States.NewGame, newGameState);
        states.Add(States.LoadGame, loadGameState);
        states.Add(States.ChapterSelect, chapterSelectState);
        states.Add(States.Gameplay, gameplayState);
        states.Add(States.Controls, controlsState);
        states.Add(States.keyBindings, keyBindingsState);
        states.Add(States.Display, displayState);
        states.Add(States.Graphics, graphicsState);
        states.Add(States.Audio, audioState);
        states.Add(States.Language, language);
    }
    public IState Get(States state) {
        Debug.Log("Null from get");
        return states[state];
    }
}