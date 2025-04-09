using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class CharacterSelection : MonoBehaviour
{
    public static UnityEvent OnBothPlayersSelected = new UnityEvent(); // Declare UnityEvent

    public Button jamesButton;
    public Button ravanduButton;
    public Button kyleButton;
    public Button fightButton;

    public AudioSource audioSource;
    public AudioClip jamesSound;
    public AudioClip ravanduSound;
    public AudioClip kyleSound;
    public AudioClip confirmSound;

    // Player 1 and Player 2 logic
    private string player1Character;
    private string player2Character;
    private bool isPlayer1Turn = true;

    private Coroutine characterSelectionCoroutine;

    void Start()
    {
        // Add listeners for character selection
        jamesButton.onClick.AddListener(SelectJames);
        ravanduButton.onClick.AddListener(SelectRavandu);
        kyleButton.onClick.AddListener(SelectKyle);

        // Fight button is hidden until both characters are selected
        fightButton.gameObject.SetActive(false);

        // Add listener for both players selecting characters
        OnBothPlayersSelected.AddListener(EnableFightButton);
    }

    void SelectJames()
    {
        SelectCharacter("James");
    }

    void SelectRavandu()
    {
        SelectCharacter("Ravandu");
    }

    void SelectKyle()
    {
        SelectCharacter("Kyle");
    }

    void SelectCharacter(string characterName)
    {
        // Play sound for character selection
        PlayCharacterSound(characterName);

        // Handle character selection for Player 1 and Player 2
        if (isPlayer1Turn)
        {
            player1Character = characterName;
            DisableButton(characterName);
        }
        else
        {
            player2Character = characterName;
            DisableAllButtons();

            // Once both players have selected, invoke the UnityEvent to enable the fight button
            OnBothPlayersSelected.Invoke();
        }

        isPlayer1Turn = !isPlayer1Turn;
    }

    void PlayCharacterSound(string name)
    {
        // Play character sound based on the selection
        if (name == "James")
        {
            audioSource.PlayOneShot(jamesSound);
        }
        else if (name == "Ravandu")
        {
            audioSource.PlayOneShot(ravanduSound);
        }
        else if (name == "Kyle")
        {
            audioSource.PlayOneShot(kyleSound);
        }
    }

    void DisableButton(string characterName)
    {
        // Disable the button for the selected character
        if (characterName == "James") jamesButton.interactable = false;
        if (characterName == "Ravandu") ravanduButton.interactable = false;
        if (characterName == "Kyle") kyleButton.interactable = false;
    }

    void DisableAllButtons()
    {
        // Disable all character selection buttons after both players have selected
        jamesButton.interactable = false;
        ravanduButton.interactable = false;
        kyleButton.interactable = false;
    }

    void EnableFightButton()
    {
        // Once both players have selected characters, make the fight button appear
        fightButton.gameObject.SetActive(true);

        // Optionally, we can start a coroutine to delay some action after the button appears
        characterSelectionCoroutine = StartCoroutine(WaitForConfirmation());
    }

    IEnumerator WaitForConfirmation()
    {
        // Introduce a small delay after the character selection
        yield return new WaitForSeconds(2f);

        // If the player wants to cancel or change their selection before the fight starts, we can handle it here
        if (player1Character != null && player2Character != null)
        {
            Debug.Log("Both players are ready to fight!");
        }
        else
        {
            // Handle cancellation logic, such as going back to character selection
            Debug.Log("Character selection was cancelled or reset.");
        }
    }

    void OnDestroy()
    {
        // Remove the listener when the object is destroyed to avoid memory leaks
        OnBothPlayersSelected.RemoveListener(EnableFightButton);

        // If the coroutine is still running, stop it
        if (characterSelectionCoroutine != null)
        {
            StopCoroutine(characterSelectionCoroutine);
        }
    }
}
