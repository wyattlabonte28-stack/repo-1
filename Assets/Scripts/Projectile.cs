using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject[] projectilePrefab;
    public GameObject gunRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




     if (Input.GetKeyDown(KeyCode.Space))
     {
                      int projectileIndex = Random.Range(0, projectilePrefab.Length);
        Instantiate(projectilePrefab[projectileIndex], transform.position, gunRotation.transform.rotation);

     }   
    }

}
