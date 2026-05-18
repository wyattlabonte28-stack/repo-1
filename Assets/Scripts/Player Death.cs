using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
    }
        private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Ground" tag
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(Enemy.gameObject);
            Debug.Log("Player got hit!");
            // Insert your landing logic here (e.g., stop falling animation)
        }

    }
}
