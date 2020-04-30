﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing;

    void Start()
    {
        
    }

    private void LateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(
                target.position.x,
                target.position.y,
                transform.position.z
            );
            transform.position = Vector3.Lerp(
                transform.position,
                targetPosition,
                smoothing
            );
        }
    }
}
