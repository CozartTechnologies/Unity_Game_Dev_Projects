﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;
    private float tileHightY;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }


    private void Update()
    {
       float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }

}
