using UnityEngine;
using UnityEngine.UI; 

public class characterChosen : MonoBehaviour
{
    public Button JamesSelected;
    public Button RavanduSelected;
    public Button KyleSelected;

  


    void Start()
    {
        JamesSelected = GetComponent<Button>();
        JamesSelected.onClick.AddListener(JamesOnButtonClicked);


        RavanduSelected = GetComponent<Button>();
        RavanduSelected.onClick.AddListener(RavanduOnButtonClicked);

        KyleSelected = GetComponent<Button>();
        KyleSelected.onClick.AddListener(KyleOnButtonClicked);

    }

    private void JamesOnButtonClicked()
    {
        Debug.Log("James chosen button was clicked!");
    }

    private void RavanduOnButtonClicked()
    {
        Debug.Log("Ravandu chosen button was clicked!");
    }

    private void KyleOnButtonClicked()
    {
        Debug.Log("Kyle chosen button was clicked!");
    }
}