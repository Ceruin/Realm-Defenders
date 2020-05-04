﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public bool isExplored = false; // ok as is a data class

    Vector2Int gridPos;

    const int gridSize = 10;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
                Mathf.RoundToInt(transform.position.x / gridSize),
                Mathf.RoundToInt(transform.position.z / gridSize)
            );
    }

    public void SetTopColor(Color color)
    {
        MeshRenderer topMeshRender = transform.Find("Top").GetComponent<MeshRenderer>();
        topMeshRender.material.color = (color);
    }
}
