using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    // Assign these in the Inspector
    public Button jamesButton;
    public Button ravanduButton;
    public Button kyleButton;
    public Button fightButton;

    // Creates audio clips in Inspector
    public AudioSource audioSource;
    public AudioClip jamesSound;
    public AudioClip ravanduSound;
    public AudioClip kyleSound;
    public AudioClip confirmSound;

    //Player 1 and Player 2 Logic
    private string player1Character;
    private string player2Character;
    private bool isPlayer1Turn = true;

    void Start()
    {
        // Setup button clicks.Will track your character selection.
        jamesButton.onClick.AddListener(() => SelectCharacter("James"));
        ravanduButton.onClick.AddListener(() => SelectCharacter("Ravandu"));
        kyleButton.onClick.AddListener(() => SelectCharacter("Kyle"));

        //Sets the fight button to false, so it doesn't appear until selection is done.
        fightButton.gameObject.SetActive(false);
    }

    void SelectCharacter(string characterName)
    {
        // Plays me saying their names haha
        PlayCharacterSound(characterName);

        //  Selection tracker, picks one, puts that string as that value then disables.
        if (isPlayer1Turn)
        {
            player1Character = characterName;
            DisableButton(characterName);
        }
        else
        {
            player2Character = characterName;
            DisableAllButtons();
            fightButton.gameObject.SetActive(true);
        }

        
        isPlayer1Turn = !isPlayer1Turn;
    }

    void PlayCharacterSound(string name)
    {
        switch (name)
        {
            case "James":
                if (jamesSound) audioSource.PlayOneShot(jamesSound);
                break;
            case "Ravandu":
                if (ravanduSound) audioSource.PlayOneShot(ravanduSound);
                break;
            case "Kyle":
                if (kyleSound) audioSource.PlayOneShot(kyleSound);
                break;
        }
    }

    void DisableButton(string characterName)
    {
        // Disables the selected character's button
        if (characterName == "James") jamesButton.interactable = false;
        if (characterName == "Ravandu") ravanduButton.interactable = false;
        if (characterName == "Kyle") kyleButton.interactable = false;
    }

    void DisableAllButtons()
    {
        jamesButton.interactable = false;
        ravanduButton.interactable = false;
        kyleButton.interactable = false;
    }

   
}