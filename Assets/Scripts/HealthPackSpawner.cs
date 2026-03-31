using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    public GameObject healthPackPrefab;
    public float spawnInterval = 8f;
    public float spawnX = 8f;
    public float minY = -2.5f;
    public float maxY = 2.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnHealthPack), 5f, spawnInterval);
    }

    void SpawnHealthPack()
    {
        if (healthPackPrefab == null) return;

        Vector3 spawnPosition = new Vector3(spawnX, Random.Range(minY, maxY), 0f);
        Instantiate(healthPackPrefab, spawnPosition, Quaternion.identity);
    }
}