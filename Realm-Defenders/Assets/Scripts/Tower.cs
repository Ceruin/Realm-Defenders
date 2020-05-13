using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Transform objectToPan;
    [SerializeField] Transform targetEnemy;
    [SerializeField] GameObject bullet;

    bool isEnemyClose;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, targetEnemy.transform.position) / 10;
        if (distance <= 10) {
            isEnemyClose = true;
        }
        else
        {
            isEnemyClose = false;
        }


        if (isEnemyClose)
        {
            TrackTarget();
            ProccessFiring(true);
        }
        else
        {
            ProccessFiring(false);
        }
    }

    private void TrackTarget()
    {
        objectToPan.LookAt(targetEnemy);
    }

    private void ProccessFiring(bool isActive)
    {
        var emissionModule = bullet.GetComponent<ParticleSystem>().emission;
        emissionModule.enabled = isActive;
    }
}
