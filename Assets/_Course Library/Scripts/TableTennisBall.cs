using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTennisBall : MonoBehaviour
{

    AudioSource audioSource;
    Rigidbody rigidBody;
    float volumeScale;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter() {
        volumeScale = rigidBody.velocity.magnitude;
        audioSource.PlayOneShot(audioSource.clip, volumeScale);
        
    }
}
