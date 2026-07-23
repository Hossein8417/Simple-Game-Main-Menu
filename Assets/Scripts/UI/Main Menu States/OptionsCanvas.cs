using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsCanvas : MonoBehaviour
{
    [Header("Panel")]
    public GameObject OptionsPanel;

    [Header("Items")]
    public TMP_Text VersionText;
    public Button GameplayButton;
    public Button ControlsButton;
    public Button keyBindingsButton;
    public Button DisplayButton;
    public Button AdvancedGraphicsButton;
    public Button AudioButton;
    public Button LanguageButton;
}
