using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{

    public GameObject lighter;
    public GameObject flames;

    public AudioSource lighterSound;

    public static bool isOn;


    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        flames.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipLight()
    {
        if (isOn)
        {
            flames.SetActive(false);
            isOn = false;
        }
        else
        {
            flames.SetActive(true);
            lighterSound.Play();
            isOn = true;
        }
        
    }
    public void TurnOnFlame()
    {
        flames.SetActive(true);
        lighterSound.Play();
        isOn = true;
    }
    public void TurnOffFlame()
    {
        flames.SetActive(false);
        isOn = false;
    }
    
}
