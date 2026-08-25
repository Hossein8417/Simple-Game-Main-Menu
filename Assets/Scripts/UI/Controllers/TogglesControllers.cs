using UnityEngine;

public class TogglesControllers : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    private void Awake()
    {
        InitialToggles();
    }

    private void OnVsyncToggleValueChanged(bool isChanged) {
        Debug.Log($"{manager.refrences.VsyncToggle.name} value is {isChanged}");
    }
    private void InitialToggles() {
        manager.refrences.VsyncToggle.isOn = false;
        manager.refrences.VsyncToggle.onValueChanged.AddListener(OnVsyncToggleValueChanged);
    }
}
