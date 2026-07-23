using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AdvancedGraphicsCanvas : MonoBehaviour
{
    [Header("Panel")]
    public GameObject GraphicsPanel;

    [Header("Items")]
    public TMP_Text VersionText;
    public TMP_Text EstimatedGraphicsUsageValueText;
    public TMP_Text TotalValueText;
    public Button ResetButton;
    public TMP_Dropdown PresetDropdown;
    public TMP_Dropdown TexturesDropdown;
    public TMP_Dropdown ModelQualityDropdown;
    public TMP_Dropdown AnistropicFilterDropdown;
    public TMP_Dropdown ShadowsDropdown;
    public TMP_Dropdown ReflectionsDropdown;
    public TMP_Dropdown AmbientOcclusionDropdown;
    public Slider GraphicsUsageSlider;
}
