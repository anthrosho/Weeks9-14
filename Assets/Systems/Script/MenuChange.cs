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

        // Setup button click listener
        transitionButton.onClick.AddListener(SwitchToCharacterSelect);
    }

    public void SwitchToCharacterSelect()
    {
        // Disable current UI
        if (Menu != null)
            Menu.SetActive(false);

        // Enable character select screen
        if (CharacterSelection != null)
            CharacterSelection.SetActive(true);
        else
            Debug.LogError("Target UI not assigned!");
    }
}
