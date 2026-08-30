using System.Collections.Generic;
using UnityEngine;
public class GameplayDropdowns : MonoBehaviour 
{
    [SerializeField]
    private UIManager _manager;

    // default modes
    ChallangeLevel defaultChallangeLevel;
    SubtitlesMode defaultSubtitlesMode;
    GameHintMode defaultGameHintMode;
    TutorialsMode defaultTutorialMode;
    PhotoMode defaultPhotoMode;
    private void Awake()
    {
        InitialDefaultGameplay();
        
        DropdownsListeners();
    }

    private void Start()
    {
        ChallangeOptions();
        SubtitleOptions();
        GameHintOptions();
        TutorialOptions();
        PhotoModeOptions();


        //these methods can go to game data class for save and load methods
        LoadDefaultChallangeLevel();
        LoadDefaultSubtitleMode();
        LoadDefaultGameHintMode();
        LoadDefaultTutorialMode();
        LoadDefaultPhotoMode();
    }
    #region OnDropdownsValuesChanged
    public void OnChallangeChanged(int index)
    {
        PlayerPrefs.SetInt(GameData.CHALLANGE_MODE, index);
        PlayerPrefs.Save();

        ChallangeLevel selectedLevel = (ChallangeLevel)index;
        Debug.Log($"challange level set to: {selectedLevel}");

    }
    public void OnSubtitleChanged(int index) {
        PlayerPrefs.SetInt(GameData.SUBTITLE_MODE, index);
        PlayerPrefs.Save();

        SubtitlesMode selectedMode = (SubtitlesMode)index;
        Debug.Log($"subtitle mode set to : {selectedMode}");
    }
    public void OnGameHintChanged(int index) {
        PlayerPrefs.SetInt(GameData.GAME_HINT_MODE, index);
        PlayerPrefs.Save();

        GameHintMode selectedGameHintMode = (GameHintMode)index;
        Debug.Log($"game hint set to : {selectedGameHintMode}");
    }
    public void OnTutorialChanged(int index) {
        PlayerPrefs.SetInt(GameData.TUTORIALS_MODE, index);
        PlayerPrefs.Save();

        TutorialsMode savedMode = (TutorialsMode)index;
        Debug.Log($"tutorail mode set to {savedMode}");
    }
    public void OnPhotoModeChanged(int index) {
        PlayerPrefs.SetInt(GameData.PHOTO_MODE, index);
        PlayerPrefs.Save();

        PhotoMode selectedPhotoMode = (PhotoMode)index;
        Debug.Log($"photo mode set to {selectedPhotoMode}");
    }


    #endregion

    #region InitalizeOptions
    private void ChallangeOptions()
    {
        _manager.refrences.ChallangeDropdown.ClearOptions();

        List<string> options = new List<string>();
        foreach (ChallangeLevel level in System.Enum.GetValues(typeof(ChallangeLevel)))
        {
            options.Add(level.ToString());
        }

        _manager.refrences.ChallangeDropdown.AddOptions(options);
    }
    private void SubtitleOptions() { 
        _manager.refrences.GameplaySubtitlesDropdown.ClearOptions();

        List<string> options = new List<string>();
        foreach (SubtitlesMode mode in System.Enum.GetValues(typeof(SubtitlesMode)))
        {
            options.Add(mode.ToString());
        }

        _manager.refrences.GameplaySubtitlesDropdown.AddOptions(options);
    }
    private void GameHintOptions() {
        _manager.refrences.GameHintDropdown.ClearOptions();
        List<string> options = new List<string>();
        foreach (GameHintMode mode in System.Enum.GetValues(typeof(GameHintMode)))
        {
            options.Add(mode.ToString());
        }

        _manager.refrences.GameHintDropdown.AddOptions(options);
    }
    private void TutorialOptions(){
        _manager.refrences.TuturialsDropdown.ClearOptions();

        List<string> options =new List<string>();
        foreach (TutorialsMode mode in System.Enum.GetValues(typeof(TutorialsMode)))
        {
            options.Add((mode.ToString()));
        }

        _manager.refrences.TuturialsDropdown.AddOptions(options);
    }
    private void PhotoModeOptions() { 
        _manager.refrences.PhotoModeDropdown.ClearOptions();
        List<string> options = new List<string>();
        foreach (PhotoMode mode in System.Enum.GetValues(typeof(PhotoMode)))
        {
            options.Add(mode.ToString());
        }
        _manager.refrences.PhotoModeDropdown.AddOptions(options);
    }

    #endregion

    #region LoadDefaultValues Methods
    //this is default levels/modes
    private void LoadDefaultChallangeLevel()
    {
        int defaultChallangeValue = PlayerPrefs.GetInt(GameData.CHALLANGE_MODE, (int)defaultChallangeLevel);

        if (defaultChallangeValue >= 0 && defaultChallangeValue < System.Enum.GetValues(typeof(ChallangeLevel)).Length)
        {
            _manager.refrences.ChallangeDropdown.value = defaultChallangeValue;
            _manager.refrences.ChallangeDropdown.RefreshShownValue();
        }
        else
        {
            _manager.refrences.ChallangeDropdown.value = (int)defaultChallangeLevel;
            _manager.refrences.ChallangeDropdown.RefreshShownValue();
        }
    } 
    private void LoadDefaultSubtitleMode() {
        int savedSubtitleMode = PlayerPrefs.GetInt(GameData.SUBTITLE_MODE, (int)defaultSubtitlesMode);

        if (savedSubtitleMode >= 0 && savedSubtitleMode < System.Enum.GetValues(typeof(SubtitlesMode)).Length)
        {
            _manager.refrences.GameplaySubtitlesDropdown.value = savedSubtitleMode;
            _manager.refrences.GameplaySubtitlesDropdown.RefreshShownValue();
        }
        else
        {
            _manager.refrences.GameplaySubtitlesDropdown.value = (int)defaultChallangeLevel;
            _manager.refrences.GameplaySubtitlesDropdown.RefreshShownValue();
        }
    }
    private void LoadDefaultGameHintMode() {
        int savedMode = PlayerPrefs.GetInt(GameData.GAME_HINT_MODE, (int)defaultGameHintMode);

        if (savedMode >= 0 && savedMode < System.Enum.GetValues(typeof(GameHintMode)).Length)
        {
            _manager.refrences.GameHintDropdown.value = savedMode;
            _manager.refrences.GameHintDropdown.RefreshShownValue();
        }
        else
        {
            _manager.refrences.GameHintDropdown.value = (int)defaultGameHintMode;
            _manager.refrences.GameHintDropdown.RefreshShownValue();
        }

    }
    private void LoadDefaultTutorialMode() {
        int savedMode = PlayerPrefs.GetInt(GameData.TUTORIALS_MODE, (int)defaultTutorialMode);

        if (savedMode >= 0 && savedMode < System.Enum.GetValues(typeof(TutorialsMode)).Length)
        {
            _manager.refrences.TuturialsDropdown.value = savedMode;
            _manager.refrences.TuturialsDropdown.RefreshShownValue();
        }
        else
        {

            _manager.refrences.TuturialsDropdown.value = (int) defaultTutorialMode;
            _manager.refrences.TuturialsDropdown.RefreshShownValue();
        }
        
    }
    private void LoadDefaultPhotoMode() {
        int savedMode = PlayerPrefs.GetInt(GameData.PHOTO_MODE, (int)defaultPhotoMode);

        if (savedMode >= 0 && savedMode < System.Enum.GetValues(typeof(PhotoMode)).Length)
        {
            _manager.refrences.PhotoModeDropdown.value = savedMode;
            _manager.refrences.PhotoModeDropdown.RefreshShownValue();
        }
        else {
            _manager.refrences.PhotoModeDropdown.value = (int)defaultPhotoMode;
            _manager.refrences.PhotoModeDropdown.RefreshShownValue();
        }
    }

    #endregion

    #region General
    private void InitialDefaultGameplay() {
        defaultChallangeLevel = ChallangeLevel.Easy;
        defaultSubtitlesMode = SubtitlesMode.Off;
        defaultGameHintMode = GameHintMode.Off;
        defaultTutorialMode = TutorialsMode.Off;
        defaultPhotoMode = PhotoMode.Off;

    }
    private void DropdownsListeners() {
        _manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnChallangeChanged);
        _manager.refrences.GameplaySubtitlesDropdown.onValueChanged.AddListener(OnSubtitleChanged);
        _manager.refrences.GameHintDropdown.onValueChanged.AddListener(OnGameHintChanged);
        _manager.refrences.TuturialsDropdown.onValueChanged.AddListener(OnTutorialChanged);
        _manager.refrences.PhotoModeDropdown.onValueChanged.AddListener(OnPhotoModeChanged);
    }
    #endregion
}