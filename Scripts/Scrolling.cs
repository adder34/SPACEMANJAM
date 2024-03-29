﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{



    public Vector2 speed = new Vector2(2, 2);

    public Vector2 direction = new Vector2(-1, 0);

    public bool isLinkedToCamera = false;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);

        movement *= Time.deltaTime;
        transform.Translate(movement);

        if (isLinkedToCamera)
        {
            Camera.main.transform.Translate(movement);
        }
    }
}
