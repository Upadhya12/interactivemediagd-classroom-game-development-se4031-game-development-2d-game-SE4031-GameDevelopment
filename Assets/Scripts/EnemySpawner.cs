using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.5f;
    public float spawnX = 9f;
    public float minY = -3f;
    public float maxY = 3f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemyPrefab == null) return;

        Vector3 spawnPosition = new Vector3(spawnX, Random.Range(minY, maxY), 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}