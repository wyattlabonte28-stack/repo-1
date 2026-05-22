using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   
    public GameObject projectilePrefab;
    public GameObject tipOfBarrel;
    public GameObject gunRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




     if (Input.GetKeyDown(KeyCode.Mouse0))
     {
                      
        Instantiate(projectilePrefab, tipOfBarrel.transform.position, gunRotation.transform.rotation);

     }   
    }
}
