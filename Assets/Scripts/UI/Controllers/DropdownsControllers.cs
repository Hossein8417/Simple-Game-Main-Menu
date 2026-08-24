using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownsControllers : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    private void Awake()
    {
        InitializeDropdowns();
    }
    private void InitializeDropdowns() {

        var challangeLevelOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("Easy"),
            new TMP_Dropdown.OptionData("Normal"),
            new TMP_Dropdown.OptionData("Hard")
        };

        var SubtitlesOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        var GameHintOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        var TutorialsOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        var PhotoModeOptions = new List<TMP_Dropdown.OptionData>
        {
            new TMP_Dropdown.OptionData("On"),
            new TMP_Dropdown.OptionData("Off")
        };

        manager.refrences.ChallangeDropdown.ClearOptions();
        manager.refrences.GameplaySubtitlesDropdown.ClearOptions();
        manager.refrences.GameHintDropdown.ClearOptions();
        manager.refrences.TuturialsDropdown.ClearOptions();
        manager.refrences.PhotoModeDropdown.ClearOptions();

        manager.refrences.ChallangeDropdown.AddOptions(challangeLevelOptions);
        manager.refrences.GameplaySubtitlesDropdown.AddOptions(SubtitlesOptions);
        manager.refrences.GameHintDropdown.AddOptions(GameHintOptions);
        manager.refrences.TuturialsDropdown.AddOptions(TutorialsOptions);
        manager.refrences.PhotoModeDropdown.AddOptions(PhotoModeOptions);

        manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnChallangeChanged);
        manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnSubtitlesChanged);
        manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnGameHintChanged);
        manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnTutorialsChanged);
        manager.refrences.ChallangeDropdown.onValueChanged.AddListener(OnPhotoModeChanged);
    }

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
}