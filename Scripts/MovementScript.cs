using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{


    public UnityEngine.Sprite PlayerLeft;
    public UnityEngine.Sprite PlayerRight;
    

    [Range(0,3)]
    public float MovementSpeed = 0.2f;
    
    Vector3 characterScale;
    float characterScaleX;

    void Start()
    {
        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
    }


    void Update()
    {
        {
            if (Input.GetKey("d"))
            {
                transform.position = new Vector2(transform.position.x + MovementSpeed, transform.position.y);
                gameObject.GetComponentInChildren<SpriteRenderer>().sprite = PlayerRight;
            }
            if (Input.GetKey("a"))
            {
                transform.position = new Vector2(transform.position.x - MovementSpeed, transform.position.y);
                gameObject.GetComponentInChildren<SpriteRenderer>().sprite = PlayerLeft;

            }
            
        }
    }


}