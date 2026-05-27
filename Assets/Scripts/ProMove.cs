

using UnityEngine;

public class ProMove : MonoBehaviour
{
    public float speed = 5.0f;
    public float delete = 50; 

    public GameObject Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        transform.Rotate(0, 269, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
        private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Ground" tag
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(Enemy.gameObject);
            Debug.Log("Enemy got hit!");
            // Insert your landing logic here (e.g., stop falling animation)
        }

    }

}
