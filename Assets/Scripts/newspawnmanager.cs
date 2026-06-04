using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Enemy Spawning")]
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public float spawnRange = 9.0f;
    public int waveNumber = 1;

    [Header("Player Respawn")]
    public GameObject playerPrefab;
    public GameObject spawnPoint;
    public float respawnDelay = 3.0f;

    [Header("Audio")]
    public AudioClip dieSound;
    public AudioClip groanSound;
    private AudioSource audioSource;

    private GameObject currentPlayer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentPlayer = GameObject.FindGameObjectWithTag("Player");
        SpawnEnemyWave(waveNumber);
    }

    void Update()
    {
        int enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }

    void SpawnEnemyWave(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

        if (audioSource != null && groanSound != null)
            audioSource.PlayOneShot(groanSound);
    }

    public void PlayerDied()
    {
        if (audioSource != null && dieSound != null)
            audioSource.PlayOneShot(dieSound);

        StartCoroutine(RespawnPlayer());
    }

    IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(respawnDelay);
        currentPlayer = Instantiate(playerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    Vector3 GenerateSpawnPosition()
    {
        float x = Random.Range(-spawnRange, spawnRange);
        float z = Random.Range(-spawnRange, spawnRange);
        return new Vector3(x, 3, z);
    }
}