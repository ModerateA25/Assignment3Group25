using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject player;

    //pickups
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    //audio
    public AudioSource[] audioSources;
    public float audioProx = 5.0f;
    public float dist;


    //text
    public Text pText;

    private void checkCompletion()
    {
        if(currentPickups >= maxPickups)
        {
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }
    }

    private void playAudio()
    {



        for(int i = 0; i < audioSources.Length; i++)
        {
            if(audioSources[i] != null)
            {

                dist = Vector3.Distance(player.transform.position, audioSources[0].transform.position);

                if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProx)
                {
                    if (!audioSources[i].isPlaying)
                    {
                        audioSources[i].Play();

                    }
                }
            }
        }
    }


    private void updateText()
    {
        pText.text = "Pickups: " + currentPickups.ToString() + "/" + maxPickups.ToString();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSources != null)
        {

            playAudio();
        }

        checkCompletion();
        updateText();

    }
}
