using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCandles : MonoBehaviour
{
    public GameObject lighterObject;
    public GameObject flame;
   

    public bool unlit;
    //public bool inReach;


    // Start is called before the first frame update
    void Awake()
    {
        unlit = true;
        flame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.tag=="Reach" && unlit && Lighter.isOn)
        {
            
            flame.SetActive(true);
            unlit = false;
           

        }
    }
  public void TurningLightOff()
    {
        print("TurningLightOff");
        unlit = true;
        flame.SetActive(false);
    }
    public void TurningLightOn()
    {
        print("TurningLightOn");
        unlit = false;
        flame.SetActive(true);
        
    }

   /* private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach" && unlit)
        {
            //inReach = false;
           // lightText.SetActive(false);
        }
    }*/
}
