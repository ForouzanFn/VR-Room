using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatedreticles : MonoBehaviour
{
    // Start is called before the first frame update
    private float _rotation = 5;
    private float _speed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, _rotation * _speed * Time.deltaTime, 0f);
    }
}
