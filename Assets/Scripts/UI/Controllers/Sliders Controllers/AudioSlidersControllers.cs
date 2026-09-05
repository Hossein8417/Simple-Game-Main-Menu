using UnityEngine;

public class AudioSlidersControllers : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    [Header("Settings")]

    [SerializeField]
    private float defaultOverallAudioVolume;

    [SerializeField]
    private float defaultEffectsAudioVolume;

    [SerializeField]
    private float defaultMusicAudioVolume;

    private void Awake()
    {
        OverallVolumeSettings();
        EffectsVolumeSettings();
        MusicVolumeSettings();

        LoadData();

        ListenToSliders();
    }


    #region LoadDefaultSettings
    private void LoadDefaultOverallAudioVolume()
    {
        float savedValue = PlayerPrefs.GetFloat(GameData.OVERALL_AUDIO, defaultOverallAudioVolume);
        if (savedValue > 100.0f || savedValue < 0)
        {
            manager.refrences.OverallSlider.value = defaultOverallAudioVolume;
            manager.refrences.OverallValueText.text = defaultOverallAudioVolume.ToString();
        }
        else
        {
            manager.refrences.OverallSlider.value = savedValue;
            manager.refrences.OverallValueText.text = savedValue.ToString();
        }

    }
    private void LoadDefaultEffectsAudioVolume()
    {
        float savedValue = PlayerPrefs.GetFloat(GameData.EFFECTS_AUDIO, defaultEffectsAudioVolume);
        if (savedValue > 100.0f || savedValue < 0)
        {
            manager.refrences.EffectsSlider.value = defaultEffectsAudioVolume;
            manager.refrences.EffectsValueText.text = defaultEffectsAudioVolume.ToString();
        }
        else
        {
            manager.refrences.EffectsSlider.value = savedValue;
            manager.refrences.EffectsValueText.text = savedValue.ToString();
        }
    }
    private void LoadDefaultMusicAudioVolume()
    {
        float savedValue = PlayerPrefs.GetFloat(GameData.MUSIC_AUDIO, defaultMusicAudioVolume);
        if (savedValue > 100.0f || savedValue < 0)
        {
            manager.refrences.MusicSlider.value = defaultMusicAudioVolume;
            manager.refrences.MusicValueText.text = defaultMusicAudioVolume.ToString();
        }
        else
        {
            manager.refrences.MusicSlider.value = savedValue;
            manager.refrences.MusicValueText.text = savedValue.ToString();
        }
    }
    #endregion 

    #region OnValuesChanged Methods
    public void OnOverallAudioVolumeChanged(float value)
    {
        manager.refrences.OverallValueText.text = value.ToString();
        PlayerPrefs.SetFloat(GameData.OVERALL_AUDIO, value);
        PlayerPrefs.Save();

    }
    public void OnEffectsAudioVolumeChanged(float value)
    {
        manager.refrences.EffectsValueText.text = value.ToString();
        PlayerPrefs.SetFloat(GameData.EFFECTS_AUDIO, value);
        PlayerPrefs.Save();
    }
    public void OnMusicAudioVolumeChanged(float value)
    {
        manager.refrences.MusicValueText.text = value.ToString();
        PlayerPrefs.SetFloat(GameData.MUSIC_AUDIO, value);
        PlayerPrefs.Save();
    }
    #endregion

    #region Settings
    public void OverallVolumeSettings()
    {
        manager.refrences.OverallSlider.minValue = 0.0f;
        manager.refrences.OverallSlider.maxValue = 100.0f;
        manager.refrences.OverallSlider.wholeNumbers = true;
    }
    public void EffectsVolumeSettings()
    {
        manager.refrences.EffectsSlider.minValue = 0.0f;
        manager.refrences.EffectsSlider.maxValue = 100.0f;
        manager.refrences.EffectsSlider.wholeNumbers = true;
    }
    public void MusicVolumeSettings()
    {
        manager.refrences.MusicSlider.minValue = 0.0f;
        manager.refrences.MusicSlider.maxValue = 100.0f;
        manager.refrences.MusicSlider.wholeNumbers = true;
    }
    #endregion

    #region General
    private void ListenToSliders()
    {
        manager.refrences.OverallSlider.onValueChanged.AddListener(OnOverallAudioVolumeChanged);
        manager.refrences.EffectsSlider.onValueChanged.AddListener(OnEffectsAudioVolumeChanged);
        manager.refrences.MusicSlider.onValueChanged.AddListener(OnMusicAudioVolumeChanged);
    }

    private void LoadData()
    {
        LoadDefaultOverallAudioVolume();
        LoadDefaultEffectsAudioVolume();
        LoadDefaultMusicAudioVolume();
    }
    #endregion
}