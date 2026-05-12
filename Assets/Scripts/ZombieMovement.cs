using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 lookDirection = (player.transform.position - transform.position).normalized;
    }
}
