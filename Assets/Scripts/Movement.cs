using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour

{
    public float speed = 5.0f;
    public float horizontalInput;
    public float verticalInput;
    public AudioClip WoodSound;
    private AudioSource MovementAudio;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MovementAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
     void Update()
    {
  //      if (Input.GetKeyDown(KeyCode.Space))
   //     {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput= Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    //    }
        MovementAudio.PlayOneShot(WoodSound, 1.0f);
        }
    }

