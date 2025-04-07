using UnityEngine;
using UnityEngine.UI; // Required for UI components

[RequireComponent(typeof(Button))] // Ensures a Button component exists
public class characterChosen : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Debug.Log("Character chosen button was clicked!");
        // You can add additional logic here
    }
}