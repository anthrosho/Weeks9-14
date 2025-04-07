using UnityEngine;
using UnityEngine.UI;

public class MenuChange : MonoBehaviour
{
    public GameObject Menu;   
    public GameObject CharacterSelection;
    public GameObject JamesSelect;
    public GameObject RavanduSelect;
    public GameObject KyleSelect;



    private Button transitionButton;

    void Start()
    {
        transitionButton = GetComponent<Button>();
        CharacterSelection.SetActive(false);
        gameObject.SetActive(true);
        CharacterSelection.SetActive(false);
        JamesSelect.SetActive(false);
        RavanduSelect.SetActive(false);
        KyleSelect.SetActive(false);

        // Watches for SwitchToCharacter and triggers on click
        transitionButton.onClick.AddListener(SwitchToCharacterSelect);
    }

    public void SwitchToCharacterSelect()
    {
        // Disable current UI
        if (Menu != false)
            Menu.SetActive(false);
   




        // Enable character select screen
        if (CharacterSelection != false)
            CharacterSelection.SetActive(true);
        JamesSelect.SetActive(true);
        RavanduSelect.SetActive(true);
        KyleSelect.SetActive(true);



    }
}
