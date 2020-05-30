using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    [Range(0.1f, 120f)]
    [SerializeField] float secondsBetweenSpawns;
    [SerializeField] EnemyMovement Enemy;
    [SerializeField] Transform enemyParentTransform;
    [SerializeField] Text enemiesSpawned;
    [SerializeField] AudioClip spawnedEnemySFX;

    int score;

    // Update is called once per frame
    void Start()
    {
        enemiesSpawned.text = score.ToString();
        StartCoroutine(RepeatedlySpawnEnemies());
    }

    IEnumerator RepeatedlySpawnEnemies()
    {
        while (true) // forever
        {
            AddScore();
            GetComponent<AudioSource>().PlayOneShot(spawnedEnemySFX);
            var newEnemy = Instantiate(Enemy, transform.position, Quaternion.identity);
            newEnemy.transform.parent = enemyParentTransform;
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

    private void AddScore()
    {
        score++;
        enemiesSpawned.text = score.ToString();
    }
}
