using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Clock : MonoBehaviour
{
    public static DateTime Now { get; }
    // Start is called before the first frame update

    public Transform minutehand;
    public Transform hourhand;
    public Transform secondhand;

    const float hoursToDegree = 360 / 12, minutesToDegrees = 360 / 60, secondToDegrees= 360/60;

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        DateTime localDate = DateTime.Now;

        hourhand.rotation = Quaternion.Euler(localDate.TimeOfDay.Hours * hoursToDegree, 0, 0);
        minutehand.rotation = Quaternion.Euler(localDate.TimeOfDay.Minutes * minutesToDegrees, 0, 0);
        secondhand.rotation = Quaternion.Euler(localDate.TimeOfDay.Seconds * secondToDegrees, 0, 0);
      
    }

    
}
