using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStapler : MonoBehaviour
{
    public GameObject staplerMain;
    public HingeJoint myHinge;
    // Start is called before the first frame update
    void Start()
    {
        var myHinge = staplerMain.GetComponent<HingeJoint>();
        myHinge.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenSesame()
    {
        myHinge.useMotor = true;
        
    }
}
