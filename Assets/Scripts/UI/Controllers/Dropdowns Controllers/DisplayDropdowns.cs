using System.Collections.Generic;
using UnityEngine;
//game must take resolutions = done 
//must set defualt resolution = done
//an system that with selecting res from dropdown , current resolution change to selected res = done 
public class DisplayDropdowns : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    private Resolution[] displayResolutions;
    private Resolution[] renderedResolutions;
    private void Awake()
    {
        DisplayResolutionOptions();
        RenderedResolutionOptions();

        LoadData();

        DisplayListeners();
        GetUserGPUInfo();
    }

    #region LoadDefaultSettings
    private void LoadDefualtDisplayResolution() {
        if (!PlayerPrefs.HasKey(GameData.DISPLAY_RESOLUTION))
        {
            //default resolution

            int screenWidth = 1280;
            int screenHeight = 720;

            Screen.SetResolution(screenWidth, screenHeight,Screen.fullScreenMode);
        }
        else {
            ApplyDisplayResolution(PlayerPrefs.GetInt(GameData.DISPLAY_RESOLUTION));
        }  
    }
    private void LoadDefualtRenderedResolution()
    {

    }
    #endregion

    #region OnValuesChanged
    public void OnDisplayResolutionChanged(int index)
    {
        Debug.Log($"display reslotion changed to {index}");
        ApplyDisplayResolution(index);
        PlayerPrefs.SetInt(GameData.DISPLAY_RESOLUTION, index);
        PlayerPrefs.Save();
    }
    public void OnRenderedResolutionChanged(int index)
    {
        Debug.Log($"rendered reslotion changed to {index}");
        ApplyRenderedResolution(index);
        PlayerPrefs.SetInt(GameData.RENDERED_RESOLUTION, index);
        PlayerPrefs.Save();
    }
    #endregion

    #region General
    private void DisplayListeners() {
        manager.refrences.DisplayResolutionDropdown.onValueChanged.AddListener(OnDisplayResolutionChanged);
        manager.refrences.RenderedResolutionDropdown.onValueChanged.AddListener(OnRenderedResolutionChanged);
    }

    private void GetUserGPUInfo()
    {
        string gpuName = SystemInfo.graphicsDeviceName;
        manager.refrences.gpuNameText.text = gpuName;
    }

    private void LoadData() {
        LoadDefualtDisplayResolution();
        LoadDefualtRenderedResolution();
    }

    private void ApplyDisplayResolution(int index)
    {
        Resolution res = displayResolutions[index];

        Screen.SetResolution(res.width, res.height, Screen.fullScreenMode);
    }

    private void ApplyRenderedResolution(int index)
    {
        Resolution res = renderedResolutions[index];

        Screen.SetResolution(res.width, res.height, Screen.fullScreenMode);
    }
    #endregion

    #region SettingsOptions
    private void DisplayResolutionOptions()
    {
        displayResolutions = new Resolution[]
        {
            new Resolution { width = 640, height = 480 },
            new Resolution { width = 800, height = 600 },
            new Resolution { width = 1024, height = 768 },
            new Resolution { width = 1280, height = 720 },
            new Resolution { width = 1280, height = 800 },
            new Resolution { width = 1366, height = 768 },
            new Resolution { width = 1440, height = 900 },
            new Resolution { width = 1600, height = 900 },
            new Resolution { width = 1680, height = 1050 },
            new Resolution { width = 1920, height = 1080 }

        };
        List<string> displayResolutionOptions = new List<string>();

        foreach (var resolution in displayResolutions)
        {
            displayResolutionOptions.Add($"{resolution.width} X {resolution.height}");
        }

        manager.refrences.DisplayResolutionDropdown.ClearOptions();

        manager.refrences.DisplayResolutionDropdown.AddOptions(displayResolutionOptions);
    }

    private void RenderedResolutionOptions() {

        renderedResolutions = new Resolution[] {
            new Resolution { width = 640, height = 360 },
            new Resolution { width = 1024, height = 576 },
            new Resolution { width = 1280, height = 720 },  
            new Resolution { width = 1366, height = 768 },   
            new Resolution { width = 1600, height = 900 },   
            new Resolution { width = 1680, height = 1050 },   
            new Resolution { width = 1776, height = 1000 },
            new Resolution { width = 1280, height = 720 },   
            new Resolution { width = 1366, height = 768 },   
            new Resolution { width = 1600, height = 900 },    
            new Resolution { width = 1680, height = 1050 },  
            new Resolution { width = 1776, height = 1000 },
            new Resolution { width = 1920, height = 1080 }
        };
        List<string> renderedResolutionOptions = new List<string>();

        manager.refrences.RenderedResolutionDropdown.ClearOptions();

        foreach (var resolution in renderedResolutions)
        {
            renderedResolutionOptions.Add($"{resolution.width} X {resolution.height}");
        }
        manager.refrences.RenderedResolutionDropdown.AddOptions(renderedResolutionOptions);
    }
    #endregion
}