using System.Collections.Generic;
using UnityEngine;

public class DisplayDropdowns : MonoBehaviour
{
    //private Resolution[] displayResolutions;
    //private List<string> displayResolutionOptions = new List<string>();

    //private Resolution[] renderedResolutions;
    //private List<string> renderedResolutionOptions = new List<string>();

    //private void Awake()
    //{
    //    manager.refrences.DisplayResolutionDropdown.ClearOptions();
    //    manager.refrences.RenderedResolutionDropdown.ClearOptions();

    //    manager.refrences.DisplayResolutionDropdown.AddOptions(displayResolutionOptions);
    //    manager.refrences.RenderedResolutionDropdown.AddOptions(displayResolutionOptions);

    //    manager.refrences.DisplayResolutionDropdown.onValueChanged.AddListener(OnDisplayResolutionChanged);
    //    manager.refrences.RenderedResolutionDropdown.onValueChanged.AddListener(OnRenderedResolutionChanged);
    //}
    //private void GetDisplayResolutions()
    //{

    //    displayResolutions = Screen.resolutions;

    //    for (int i = 0; i < displayResolutions.Length; i++)
    //    {
    //        string option = $"{displayResolutions[i].width} X {displayResolutions[i].height} @ {displayResolutions[i].refreshRateRatio}Hz";

    //        displayResolutionOptions.Add(option);
    //    }
    //}

    //private void GetRenderedResolutions()
    //{

    //    renderedResolutions = Screen.resolutions;

    //    for (int i = 0; i < renderedResolutions.Length; i++)
    //    {
    //        string option = $"{renderedResolutions[i].width} X {renderedResolutions[i].height} @ {renderedResolutions[i].refreshRateRatio}Hz";

    //        renderedResolutionOptions.Add(option);
    //    }
    //}
    //private void GetDisplayAspects()
    //{
    //    //this logic must improve
    //    //Debug.Log($"{Screen.width/Screen.height}");

    //}

    //private void GetUserGPUInfo()
    //{
    //    string gpuName = SystemInfo.graphicsDeviceName;
    //    manager.refrences.gpuNameText.text = gpuName;
    //}
    //private void GetUserMonitorsList()
    //{
    //    string displayMonitor = Display.main.ToString();

    //    manager.refrences.DisplayMonitorDropdown.name = displayMonitor;

    //    //bug
    //}

    //public void OnDisplayResolutionChanged(int index)
    //{
    //    Debug.Log($"reslotion changed to {index}");
    //}
    //public void OnRenderedResolutionChanged(int index)
    //{
    //    Debug.Log($"rendered reslotion changed to {index}");
    //}
}