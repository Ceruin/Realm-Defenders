using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float secondsBetweenSpawns;
    [SerializeField] EnemyMovement Enemy;
    int totalEnemies = 100;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(RepeatedlySpawnEnemies());
    }

    IEnumerator RepeatedlySpawnEnemies()
    {
        while (totalEnemies > 0) // true for forever
        {
            print("Spawning");
            Instantiate(Enemy);
            totalEnemies--;
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }
}
