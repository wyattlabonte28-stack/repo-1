using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound) 
        {
            Debug.Log("posZ");
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("negZ");
            Destroy(gameObject);
        }

// if an object goes past the players view in the game, remove that object
        if (transform.position.x > topBound) 
        {
            Debug.Log("posX");
            Destroy(gameObject);
        } else if (transform.position.x < lowerBound)
        {
            Debug.Log("negX");
            Destroy(gameObject);
        }
    }
}
