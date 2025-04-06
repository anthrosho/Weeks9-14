using UnityEngine;
using UnityEngine.UI;

public class MenuChange : MonoBehaviour
{
    public GameObject Menu;   
    public GameObject CharacterSelection;    

    private Button transitionButton;

    void Start()
    {
        transitionButton = GetComponent<Button>();
        CharacterSelection.SetActive(false);
        
        // Watches for SwitchToCharacter and triggers on click
        transitionButton.onClick.AddListener(SwitchToCharacterSelect);
    }

    public void SwitchToCharacterSelect()
    {
        // Disable current UI
        if (Menu != false)
            Menu.SetActive(false);
        gameObject.SetActive(false);
        CharacterSelection.SetActive(false);


        // Enable character select screen
        if (CharacterSelection != false)
            CharacterSelection.SetActive(true);

   
    }
}
