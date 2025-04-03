using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoAndStop : MonoBehaviour
{
    public Image image;
    public Sprite trafficLightRed;
    public Sprite trafficLightGreen;

    // Start is called before the first frame update

     

public void MouseIsOverUs()
    {
        image.sprite = trafficLightGreen;

    }

    public void MouseIsNotOverUs()

    {
        image.sprite = trafficLightRed;

    }

}
