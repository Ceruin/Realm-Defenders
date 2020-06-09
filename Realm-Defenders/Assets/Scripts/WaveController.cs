using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    EnemySpawner enemySpawner;

    Stopwatch test = new Stopwatch();

    [SerializeField] List<Wave> waveList = new List<Wave>();

    // Start is called before the first frame update
    void Start()
    {
        enemySpawner = GetComponent<EnemySpawner>();

        test.Start();
    }

    private void SetSpawnerSpeed(float amountOfSecondsToReduce)
    {       
            enemySpawner.secondsBetweenSpawns = Mathf.Clamp(amountOfSecondsToReduce, 0.1f, 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Wave wave in waveList)
        {
            if (test.Elapsed.Seconds > wave.secondsTillStart && !wave.isStarted)
            {
                SetSpawnerSpeed(wave.spawnerSpeed);
                wave.isStarted = true;
            }
        }
    }
}
