using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)] float gridSize = 10f; 

    // Update is called once per frame
    void Update()
    {
        Vector3 snapPos;
        snapPos.x = GetSnapPos(transform.position.x);
        snapPos.z = GetSnapPos(transform.position.z);

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);
    }

    private float GetSnapPos(float transformPos)
    {
        return Mathf.RoundToInt(transformPos / gridSize) * gridSize;
    }
}
