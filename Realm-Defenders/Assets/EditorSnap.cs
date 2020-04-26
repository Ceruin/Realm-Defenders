using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class EditorSnap : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)] float gridSize = 10f;

    TextMesh textMesh;

    // Update is called once per frame
    void Update()
    {
        Vector3 snapPos;

        snapPos.x = GetSnapPos(transform.position.x);
        snapPos.z = GetSnapPos(transform.position.z);
        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = snapPos.x  / gridSize + "," + snapPos.z / gridSize;
    }

    private float GetSnapPos(float transformPos)
    {
        return Mathf.RoundToInt(transformPos / gridSize) * gridSize;
    }
}
