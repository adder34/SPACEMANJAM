using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderClimbing : MonoBehaviour
{
    [Range(1, 10)]
    public float ClimbSpeed = 2;

    private float InputVertical;
    private Rigidbody2D RB;
    public float Distance;
    public LayerMask WhatIsLadder;
    private bool IsClimbing;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, Distance, WhatIsLadder);

        if(hitInfo.collider != null)
        {
            if (Input.GetKey("w"))
            {
                IsClimbing = true;
            }
        }
        else
        {
            IsClimbing = false;
        }
        if(IsClimbing == true)
        {
            InputVertical = Input.GetAxisRaw("Vertical");
            RB.velocity = new Vector2(RB.velocity.x, InputVertical * ClimbSpeed);
        }
         
    }
}
