//space, A, D
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public float moveStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.linearVelocity = Vector2.up * jumpStrength;
        }
        else if (Input.GetKeyDown(KeyCode.A) == true)
        {
            myRigidbody.linearVelocity = Vector2.left * moveStrength;
        }
        else if (Input.GetKeyDown(KeyCode.D) == true)
        {
            myRigidbody.linearVelocity = Vector2.right * moveStrength;
        }
    }
}
