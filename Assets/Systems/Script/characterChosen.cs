using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelectionManager : MonoBehaviour
{
    [Header("UI Elements")]
    public Button[] characterButtons;
    public Button beginCombatButton;
    public Text selectionPrompt;

    [Header("Settings")]
    public string combatSceneName = "CombatScene";

    private string player1Selection;
    private string player2Selection;
    private bool isPlayer1Turn = true;

    void Start()
    {
        InitializeSelectionSystem();
        beginCombatButton.gameObject.SetActive(false);
    }

    void InitializeSelectionSystem()
    {
        foreach (Button button in characterButtons)
        {
            button.onClick.AddListener(() => HandleCharacterSelection(button.name));
        }

        UpdateSelectionPrompt();
        beginCombatButton.onClick.AddListener(StartCombat);
    }

    void HandleCharacterSelection(string characterName)
    {
        if (isPlayer1Turn)
        {
            player1Selection = characterName;
            DisableCharacterButton(characterName);
        }
        else
        {
            player2Selection = characterName;
            foreach (Button button in characterButtons)
            {
                button.interactable = false;
            }
            beginCombatButton.gameObject.SetActive(true);
        }

        isPlayer1Turn = !isPlayer1Turn;
        UpdateSelectionPrompt();
    }

    void DisableCharacterButton(string characterName)
    {
        foreach (Button button in characterButtons)
        {
            if (button.name == characterName)
            {
                button.interactable = false;
                break;
            }
        }
    }

    void UpdateSelectionPrompt()
    {
        selectionPrompt.text = isPlayer1Turn ?
            "Player 1: Choose Your Character" :
            "Player 2: Choose Your Character";
    }

    void StartCombat()
    {
        PlayerPrefs.SetString("Player1Character", player1Selection);
        PlayerPrefs.SetString("Player2Character", player2Selection);
        SceneManager.LoadScene(combatSceneName);
    }
}