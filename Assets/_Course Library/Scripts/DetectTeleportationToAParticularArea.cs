using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTeleportationToAParticularArea : MonoBehaviour
{
    public Canvas hatCanvas;
    int hat = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Human" && hat==0)
        {
            hat++;
            hatCanvas.gameObject.SetActive(true);
        }
        

    }
}
