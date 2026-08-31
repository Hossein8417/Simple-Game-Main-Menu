using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    [SerializeField]
    private UIManager manager;

    private void Awake()
    {
        LoadS1GameValues();
        LoadS2GameValues();
        LoadS3GameValues();
    }
    private void Start()
    {
        AddButtonsListeners();
    }
    #region On Clicked Methods
    private void OnNewGame1Clicked() {
        GetInformationToButtons(manager.refrences.S1challangeText, manager.refrences.S1dateTimeText);
        SceneManager.LoadScene("Game");
    }
    private void OnNewGame2Clicked()
    {
        GetInformationToButtons(manager.refrences.S2challangeText, manager.refrences.S2dateTimeText);
        SceneManager.LoadScene("Game");
    }
    private void OnNewGame3Clicked()
    {
        GetInformationToButtons(manager.refrences.S3challangeText, manager.refrences.S3dateTimeText);
        SceneManager.LoadScene("Game");
    }
    private void OnLoadGame1Clicked() {
        GetLoadInformationToButtons();
        SceneManager.LoadScene("Game");
    }
    private void OnLoadGame2Clicked()
    {
        GetLoadInformationToButtons();
        SceneManager.LoadScene("Game");
    }
    private void OnLoadGame3Clicked()
    {
        GetLoadInformationToButtons();
        SceneManager.LoadScene("Game");
    }

    #endregion

    #region Load Methods
    private void LoadS1GameValues()
    {
        GetLoadValues(manager.refrences.S1challangeText, manager.refrences.S1dateTimeText,
            manager.refrences.S1LoadchallangeText, manager.refrences.S1LoaddateTimeText);

    }
    private void LoadS2GameValues()
    {
        GetLoadValues(manager.refrences.S2challangeText, manager.refrences.S2dateTimeText,
            manager.refrences.S2LoadchallangeText, manager.refrences.S2LoaddateTimeText);
    }
    private void LoadS3GameValues()
    {
        GetLoadValues(manager.refrences.S3challangeText, manager.refrences.S3dateTimeText, 
            manager.refrences.S3LoadchallangeText, manager.refrences.S3LoaddateTimeText);
    }
    #endregion

    #region General Methods
    private void AddButtonsListeners()
    {
        manager.refrences.Slot1NewGameButton.onClick.AddListener(OnNewGame1Clicked);
        manager.refrences.Slot2NewGameButton.onClick.AddListener(OnNewGame2Clicked);
        manager.refrences.Slot3NewGameButton.onClick.AddListener(OnNewGame3Clicked);
        manager.refrences.Slot1LoadGameButton.onClick.AddListener(OnLoadGame1Clicked);
        manager.refrences.Slot2LoadGameButton.onClick.AddListener(OnLoadGame2Clicked);
        manager.refrences.Slot3LoadGameButton.onClick.AddListener(OnLoadGame3Clicked);
    }
    private void GetInformationToButtons(TMP_Text slotChallangeText, TMP_Text slotDataTimeText) {
        int savedValue = PlayerPrefs.GetInt(GameData.CHALLANGE_MODE);

        ChallangeLevel level = (ChallangeLevel)savedValue;

        slotChallangeText.text = $"Challange Mode : {level}";

        string dateTime = GameData.Instance.DateTime();

        PlayerPrefs.SetString(GameData.DATA_AND_TIME, dateTime);

        slotDataTimeText.text = $"Date & Time : {dateTime}";
    }
    private void GetLoadInformationToButtons() {
        //must take data and settings from player prefs
        //and when new game saved, this information must save to player prefs to give this info's to other sections
        int savedChallange = PlayerPrefs.GetInt(GameData.CHALLANGE_MODE);
        print($"Challange set to : {(ChallangeLevel)savedChallange}");
    }
    private void GetLoadValues(TMP_Text slotChallangeText, TMP_Text slotDataTimeText
        ,TMP_Text slotLoadChallangeText, TMP_Text slotLoadDataTimeText) {

        if (slotChallangeText.text != string.Empty && slotDataTimeText.text != string.Empty)
        {
            slotLoadChallangeText.text = slotChallangeText.text;
            slotLoadDataTimeText.text = slotDataTimeText.text;
        }
        else slotLoadChallangeText.text = "Challange Mode: ";
    }

    #endregion
}