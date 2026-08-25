using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
public class DropdownsControllers : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    private Resolution[] displayResolutions;
    private List<string> displayResolutionOptions = new List<string>();

    private Resolution[] renderedResolutions;
    private List<string> renderedResolutionOptions = new List<string>();

    private void Awake()
    {
        GetDisplayResolutions();
        GetRenderedResolutions();
        GetDisplayAspects();
        GetUserGPUInfo();
        GetUserMonitorsList();
        InitializeDropdowns();
    }
    private void InitializeDropdowns() {

        var challangeLevelOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("Easy"),
            new TMP_Dropdown.OptionData("Normal"),
            new TMP_Dropdown.OptionData("Hard")
        };

        var subtitlesOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        var gameHintOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        var tutorialsOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        var photoModeOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        manager.refrences.ChallangeDropdown.ClearOptions();
        manager.refrences.GameplaySubtitlesDropdown.ClearOptions();
        manager.refrences.GameHintDropdown.ClearOptions();
        manager.refrences.TuturialsDropdown.ClearOptions();
        manager.refrences.PhotoModeDropdown.ClearOptions();
        manager.refrences.DisplayResolutionDropdown.ClearOptions();
        manager.refrences.RenderedResolutionDropdown.ClearOptions();

        manager.refrences.ChallangeDropdown.AddOptions(challangeLevelOptions);
        manager.refrences.GameplaySubtitlesDropdown.AddOptions(subtitlesOptions);
        manager.refrences.GameHintDropdown.AddOptions(gameHintOptions);
        manager.refrences.TuturialsDropdown.AddOptions(tutorialsOptions);
        manager.refrences.PhotoModeDropdown.AddOptions(photoModeOptions);
        manager.refrences.DisplayResolutionDropdown.AddOptions(displayResolutionOptions);
        manager.refrences.RenderedResolutionDropdown.AddOptions(displayResolutionOptions);

        manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnChallangeChanged);
        manager.refrences.GameplaySubtitlesDropdown.onValueChanged.AddListener(OnSubtitlesChanged);
        manager.refrences.GameHintDropdown.onValueChanged.AddListener(OnGameHintChanged);
        manager.refrences.TuturialsDropdown.onValueChanged.AddListener(OnTutorialsChanged);
        manager.refrences.PhotoModeDropdown.onValueChanged.AddListener(OnPhotoModeChanged);
        manager.refrences.DisplayResolutionDropdown.onValueChanged.AddListener(OnDisplayResolutionChanged);
        manager.refrences.RenderedResolutionDropdown.onValueChanged.AddListener(OnRenderedResolutionChanged);
    }

    #region OnValuesChanges Methods
    public void OnChallangeChanged(int index) {
        Debug.Log($"Challange level changed to: {manager.refrences.ChallangeDropdown.options[index].text}");
    }
    public void OnSubtitlesChanged(int index)
    {
        Debug.Log($"subtitle mode changed to: {manager.refrences.ChallangeDropdown.options[index].text}");
    }
    public void OnGameHintChanged(int index)
    {
        Debug.Log($"game hint mode changed to: {manager.refrences.ChallangeDropdown.options[index].text}");
    }
    public void OnTutorialsChanged(int index)
    {
        Debug.Log($"tutorials mode changed to: {manager.refrences.ChallangeDropdown.options[index].text}");
    }
    public void OnPhotoModeChanged(int index)
    {
        Debug.Log($"photo mode mode changed to: {manager.refrences.ChallangeDropdown.options[index].text}");
    }
    public void OnDisplayResolutionChanged(int index) {
        Debug.Log($"reslotion changed to {index}");
    }
    public void OnRenderedResolutionChanged(int index)
    {
        Debug.Log($"rendered reslotion changed to {index}");
    }
    #endregion

    private void GetDisplayResolutions() {
        
        displayResolutions = Screen.resolutions;

        for (int i = 0; i < displayResolutions.Length; i++)
        {
            string option = $"{displayResolutions[i].width} X {displayResolutions[i].height} @ {displayResolutions[i].refreshRateRatio}Hz";

            displayResolutionOptions.Add(option);
        }        
    }

    private void GetRenderedResolutions()
    {

        renderedResolutions = Screen.resolutions;

        for (int i = 0; i < renderedResolutions.Length; i++)
        {
            string option = $"{renderedResolutions[i].width} X {renderedResolutions[i].height} @ {renderedResolutions[i].refreshRateRatio}Hz";

            renderedResolutionOptions.Add(option);
        }
    }
    private void GetDisplayAspects() {
        //this logic must improve
        Debug.Log($"{Screen.width/Screen.height}");

    }

    private void GetUserGPUInfo() {
        string gpuName = SystemInfo.graphicsDeviceName;
        manager.refrences.gpuNameText.text = gpuName;
    }
    private void GetUserMonitorsList() {
        string displayMonitor = Display.main.ToString();

        manager.refrences.DisplayMonitorDropdown.name = displayMonitor;

        //bug
    }
}