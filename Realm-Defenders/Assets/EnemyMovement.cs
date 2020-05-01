using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path;
    int test = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator FollowPath()
    {
        print("Starting patrol...");
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("Visiting Block: " + waypoint.name);
            test += 1;
            yield return new WaitForSeconds(1f);            
        }
        print("Ending patrol");
    }
}
