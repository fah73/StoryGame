using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject stickPrefab;

    public float spawnWidth = 8f;
    public float spawnHeight = 6f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while(true)
        {
            SpawnObject();

            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
    }

void SpawnObject()
{
    float randomX = Random.Range(-spawnWidth, spawnWidth);
    Vector2 spawnPosition = new Vector2(randomX, spawnHeight);

    int randomChoice = Random.Range(0, 3);

    if(randomChoice == 0 && coinPrefab != null)
    {
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
    else if(stickPrefab != null)
    {
        Instantiate(stickPrefab, spawnPosition, Quaternion.identity);
    }
}
}