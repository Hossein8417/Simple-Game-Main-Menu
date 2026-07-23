using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DisplayCanvas : MonoBehaviour
{
    [Header("Panel")]
    public GameObject DisplayPanel;

    [Header("Items")]
    public TMP_Text VersionText;
    public TMP_Dropdown DisplayModeDropdown;
    public TMP_Dropdown MonitorDropdown;
    public TMP_Dropdown DisplayResolutionDropdown;
    public TMP_Dropdown RenderedResolutionDropdown;
    public TMP_Dropdown AspectRatioDropdown;
    public TMP_Dropdown MethodDropdown;
    public TMP_Dropdown VsyncDropdown;
}
