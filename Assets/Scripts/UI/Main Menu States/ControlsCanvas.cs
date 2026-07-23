using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ControlsCanvas : MonoBehaviour
{
    [Header("Panel")]
    public GameObject ControlsPanel;

    [Header("Items")]
    public TMP_Text VersionText;
    public TMP_Text MouseSenitivityValueText;
    public TMP_Text CameraSenitivityValueText;
    public TMP_Text ControllerSenitivityValueText;
    public Slider MouseSenitivity;
    public Slider CameraSenitivity;
    public Slider ControllerSenitivity;
}
