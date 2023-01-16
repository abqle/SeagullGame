using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWithVerticalSprite : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float speed;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        float verticalmovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement, verticalmovement, 0) * speed;

        


        

    }


}
