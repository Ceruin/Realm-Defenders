using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Transform objectToPan;
    [SerializeField] Transform targetEnemy;
    [SerializeField] GameObject bullet;
    [SerializeField] ParticleSystem projectileParticle; // same thing as bullet
    [SerializeField] float attackRange = 10;  

    // Update is called once per frame
    void Update()
    {
        if (targetEnemy)
        {
            TrackTarget();
            FireAtEnemy();
        } else
        {
            Shoot(false);
        }
    }

    private void TrackTarget()
    {
        objectToPan.LookAt(targetEnemy);
    }

    private void FireAtEnemy()
    {
        float distance = Vector3.Distance(targetEnemy.transform.position, gameObject.transform.position);

        if (distance <= attackRange)
        {
            Shoot(true);
        }
        else
        {
            Shoot(false);
        }
    }

    private void Shoot(bool isActive)
    {
        var emissionModule = bullet.GetComponent<ParticleSystem>().emission;
        emissionModule.enabled = isActive;
    }
}
