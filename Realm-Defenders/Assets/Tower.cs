using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Transform objectToPan;
    [SerializeField] Transform targetEnemy;
    [SerializeField] GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        TrackTarget();
        ProccessFiring(true);

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
