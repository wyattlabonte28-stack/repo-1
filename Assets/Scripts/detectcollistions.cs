using UnityEngine;
using System.Collections;

public class DetectCollisions : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public float respawnDelay = 3.0f;
    private GameObject currentPlayer;
    private bool isRespawning = false;

    void Start()
    {
        currentPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(currentPlayer);
        }
    }

    void Update()
    {
        if (currentPlayer == null && !isRespawning)
        {
            StartCoroutine(RespawnRoutine());
        }
    }

    IEnumerator RespawnRoutine()
    {
        isRespawning = true;
        yield return new WaitForSeconds(respawnDelay);
        currentPlayer = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        isRespawning = false;
    }
}

