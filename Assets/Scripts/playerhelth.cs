using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SpawnManager sm = FindObjectOfType<SpawnManager>();
            if (sm != null)
            {
                sm.PlayerDied();
            }
            Destroy(gameObject);
        }
    }
}