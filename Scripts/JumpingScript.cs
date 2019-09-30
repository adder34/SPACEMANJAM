using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    [Range(1, 10)]
    public float JumpVelocity = 5;

    [Range(0f, 2f)]
    public float JumpTimer;

    private float CanJump = 0f;

    void Update()
    {
        if (Input.GetKeyDown("w") && Time.time > CanJump)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpVelocity;
            CanJump = Time.time + JumpTimer;
        }
    }
}
