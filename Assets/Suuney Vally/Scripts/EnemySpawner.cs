using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Vector2 spawnAreaSize = new Vector2(10, 10);
    public float spawnRate = 1f;
    public float minSpawnRate = 0.2f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        if (GameManager.instance.isGameOver)
        {
            CancelInvoke("SpawnEnemy");
            return;
        }

        Vector2 randomPos = new Vector2(
            Random.Range(-spawnAreaSize.x, spawnAreaSize.x),
            Random.Range(-spawnAreaSize.y, spawnAreaSize.y)
        );

        Instantiate(enemyPrefab, randomPos, Quaternion.identity);

        // Increase difficulty
        if (spawnRate > minSpawnRate)
        {
            spawnRate -= 0.05f;

            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 1f, spawnRate);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Vector3.zero, spawnAreaSize * 2);
    }
}