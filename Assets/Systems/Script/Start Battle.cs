using UnityEngine;
using UnityEngine.UI;

public class StartBattle : MonoBehaviour
{
    public Button battleButton;
    public GameObject battleImage;
    public GameObject characterSelectionUI;
    public GameObject jamesSelect;
    public GameObject ravanduSelect;
    public GameObject kyleSelect;

    public AudioClip battleStartSound;
    public AudioSource audioSource;

    void Start()
    {
        // Makes sure the audio clip exists
        if (audioSource == false)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }

        // Sets the image to false and the button activating a function  
        battleImage.SetActive(false);
        battleButton.onClick.AddListener(OnBattleButtonClicked);
    }

    void OnBattleButtonClicked()
    {
        audioSource.PlayOneShot(battleStartSound);

        characterSelectionUI.SetActive(false);
        jamesSelect.SetActive(false);
        ravanduSelect.SetActive(false);
        kyleSelect.SetActive(false);
        battleImage.SetActive(true);
    }
}