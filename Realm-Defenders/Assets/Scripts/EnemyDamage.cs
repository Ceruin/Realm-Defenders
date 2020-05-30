using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int hitPoints = 10;
    [SerializeField] ParticleSystem hitParticlePrefab;
    [SerializeField] ParticleSystem deathParticlePrefab;
    [SerializeField] AudioClip enemyHitSFX;
    [SerializeField] AudioClip enemyDeathSFX;

    AudioSource myAudioSource;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hitPoints <= 0)
        {
            KillEnemy();
        }
    }

    private void ProcessHit()
    {
        GetComponent<AudioSource>().PlayOneShot(enemyHitSFX);
        hitPoints -= 1;
        hitParticlePrefab.Play();
    }

    int hits;

    private void KillEnemy()
    {     
        var deathFX = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
        deathFX.Play();

        Destroy(deathFX.gameObject, deathFX.main.duration);
        AudioSource.PlayClipAtPoint(enemyDeathSFX, Camera.main.transform.position);
        Destroy(gameObject);        
    }
}
