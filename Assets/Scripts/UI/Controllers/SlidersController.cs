using UnityEngine;
using UnityEngine.UI;
public class SlidersController : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;
    
    private void Awake()
    {
        ListenToSliders();
        MouseValueSettings();
        CameraValueSettings();
        ControllerValueSettings();
    }

    private void ListenToSliders() {

        manager.refrences.MouseSenitivity.onValueChanged.AddListener(OnMouseSentivityValueChanged);
        manager.refrences.CameraSenitivity.onValueChanged.AddListener(OnCameraSentivityValueChanged);
        manager.refrences.ControllerSenitivity.onValueChanged.AddListener(OnControllerSentivityValueChanged);
    }
    #region On Values Changed
    public void OnMouseSentivityValueChanged(float value) { 
        manager.refrences.MouseSenitivityValueText.text = value.ToString();
    }
    public void OnCameraSentivityValueChanged(float value)
    {
        manager.refrences.CameraSenitivityValueText.text = value.ToString();
    }
    public void OnControllerSentivityValueChanged(float value)
    {
        manager.refrences.ControllerSenitivityValueText.text = value.ToString();
    }
    #endregion

    #region Settings
    public void MouseValueSettings() {
        manager.refrences.MouseSenitivity.minValue = 0.0f;
        manager.refrences.MouseSenitivity.maxValue = 100.0f;
        manager.refrences.MouseSenitivity.wholeNumbers = true;
    }
    public void CameraValueSettings()
    {
        manager.refrences.CameraSenitivity.minValue = 0.0f;
        manager.refrences.CameraSenitivity.maxValue = 100.0f;
        manager.refrences.CameraSenitivity.wholeNumbers = true;
    }
    public void ControllerValueSettings()
    {
        manager.refrences.ControllerSenitivity.minValue = 0.0f;
        manager.refrences.ControllerSenitivity.maxValue = 100.0f;
        manager.refrences.ControllerSenitivity.wholeNumbers = true;
    }
    #endregion
}