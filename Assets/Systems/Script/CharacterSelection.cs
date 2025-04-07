using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{

    //Declare clip, source and button
    public AudioClip audioClip;
    public AudioSource audioSource;
    private Button button;

    void Start()
    {
        //Set these so the that when the button is pressed, it'll call upon Play Audio!
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayAudio);

        
    }

    public void PlayAudio()
    {
        if (audioClip != null && audioSource != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
      
        }
    }
