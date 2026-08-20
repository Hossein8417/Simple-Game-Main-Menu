using UnityEngine;
using TMPro;
public class VersionShower : MonoBehaviour
{
    [SerializeField]
    private TMP_Text versionText;

    private void Start()
    {
        string version = "v1.60";
        versionText.text = version;
    }
}
