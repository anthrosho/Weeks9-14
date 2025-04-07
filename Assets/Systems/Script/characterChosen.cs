using UnityEngine;
using UnityEngine.UI;

public class characterChosen : MonoBehaviour
{
    public Button jamesButton;
    public Button ravanduButton;
    public Button kyleButton;

    void Start()
    {
        // James button
        jamesButton.onClick.AddListener(() => {
            Debug.Log("James chosen button was clicked!");
        });

        // Ravandu button
        ravanduButton.onClick.AddListener(() => {
            Debug.Log("Ravandu chosen button was clicked!");
        });

        // Kyle button
        kyleButton.onClick.AddListener(() => {
            Debug.Log("Kyle chosen button was clicked!");
        });
    }
}