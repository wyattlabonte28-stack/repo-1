using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   
    public GameObject projectilePrefab;
    public GameObject tipOfBarrel;
    public GameObject gunRotation;
    public AudioClip GunSound;
    private AudioSource ProjectileAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ProjectileAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {




     if (Input.GetKeyDown(KeyCode.Mouse0))
     {
                   ProjectileAudio.PlayOneShot(GunSound, 1.0f);   
        Instantiate(projectilePrefab, tipOfBarrel.transform.position, gunRotation.transform.rotation);
        
     }   
    }
}
