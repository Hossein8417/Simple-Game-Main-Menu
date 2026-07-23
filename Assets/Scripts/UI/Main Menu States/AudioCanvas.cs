using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AudioCanvas : MonoBehaviour
{
    [Header("Panel")]
    public GameObject AudioPanel;

    [Header("Items")]
    public TMP_Text VersionText;
    public TMP_Text OverallValueText;
    public TMP_Text EffectsValueText;
    public TMP_Text MusicValueText;
    public TMP_Text DialogueValueText;
    public TMP_Text CinematicsValueText;
    public Slider OverallSlider;
    public Slider EffectsSlider;
    public Slider MusicSlider;
    public Slider DialogueSlider;
    public Slider CinematicsSlider;
    public Button ResetButton;

}
