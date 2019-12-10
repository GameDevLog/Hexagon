using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexoagonPrefab;
    private float nextTimeToSpawn;

    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexoagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
