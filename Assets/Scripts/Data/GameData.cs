using UnityEngine;
//save game => وقتی بازی سیو میشه دیگه مهم نیست باز ران باشه یا نه اون اطلاعات تو دیسک سیو میشن و دیگه نباید حذف بشن 
//load game => وقتی بازی لود میشه فقط باید اطلاعات قبلی رو بخونه واگر اطلاعات قبلی نبود اطلاعات دیفالت 


public class GameData : MonoBehaviour
{
    //in this script first of all must complete other player prefs after that must refactor code and for last changing of the code , must create save and load methods to use it everywhere!
    public static GameData Instance { get; private set; }

    public const string CHALLANGE_MODE = "ChallangeMode";
    public const string DATA_AND_TIME = "DateAndTime";
    public const string SUBTITLE_MODE = "SubtitleMode";
    public const string GAME_HINT_MODE = "GameHintMode";
    public const string TUTORIALS_MODE = "TutorialsMode";
    public const string PHOTO_MODE = "PhotoMode";   

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public string DateTime() {
        string date = System.DateTime.Now.ToString("yyyy/dd/MM");
        string time = System.DateTime.Now.ToString("HH/mm");
        return $"Date:{date}\nTime:{time}";
    }
}