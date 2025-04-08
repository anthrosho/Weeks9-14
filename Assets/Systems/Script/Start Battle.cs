using UnityEngine;
using UnityEngine.UI;

public class StartBattle : MonoBehaviour
{
    [Header("UI References")]
    public Button battleButton;
    public GameObject battleImage;
    public GameObject characterSelectionUI;
    public GameObject jamesSelect;
    public GameObject ravanduSelect;
    public GameObject kyleSelect;

    void Start()
    {
        // Battle image is hidden at start
        battleImage.SetActive(false);

        battleButton.onClick.AddListener(OnBattleButtonClicked);
    }

    void OnBattleButtonClicked()
    {
        // Disable character selection elements
        characterSelectionUI.SetActive(false);
        jamesSelect.SetActive(false);
        ravanduSelect.SetActive(false);
        kyleSelect.SetActive(false);

        // Enables THE arena
        battleImage.SetActive(true);
    }
}