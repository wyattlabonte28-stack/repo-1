using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // Drag the player here in the inspector
    public float moveForce = 10f;
    private Rigidbody rb;
    public GameObject pro;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        // Optional: Find player automatically if not assigned
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate() // Use FixedUpdate for physics-based movement
    {
        if (player != null)
        {
            // 1. Calculate direction to player
            Vector3 direction = (player.position - transform.position).normalized;

            // 2. Apply force to move the enemy
            rb.AddForce(direction * moveForce);

            // 3. Make enemy face the player (optional)
            transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
        }
    }
private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Ground" tag
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Enemy hit the ground!");
                        Destroy(gameObject);
            Destroy(pro.gameObject);
            // Insert your landing logic here (e.g., stop falling animation)
        }
    }
  //          if (collision.gameObject.CompareTag("Enemy"))
  //      {
   //         Destroy(gameObject);
   //         Destroy(Enemy.gameObject);
   //         Debug.Log("Enemy got hit!");
   //         // Insert your landing logic here (e.g., stop falling animation)
  //      }
}
