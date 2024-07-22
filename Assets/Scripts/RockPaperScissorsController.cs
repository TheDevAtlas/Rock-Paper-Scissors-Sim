using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissorsController : MonoBehaviour
{
    public GameObject rockPrefab;
    public GameObject paperPrefab;
    public GameObject scissorsPrefab;
    public int numberOfRocks = 10;
    public int numberOfPapers = 10;
    public int numberOfScissors = 10;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;

    public float time = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnEntities(rockPrefab, numberOfRocks));
        StartCoroutine(SpawnEntities(paperPrefab, numberOfPapers));
        StartCoroutine(SpawnEntities(scissorsPrefab, numberOfScissors));
    }

    IEnumerator SpawnEntities(GameObject prefab, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Vector2 spawnPosition = new Vector2(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y)
            );
            Instantiate(prefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }

    void Update()
    {
        time -= Time.deltaTime / 10f;
    }
}
