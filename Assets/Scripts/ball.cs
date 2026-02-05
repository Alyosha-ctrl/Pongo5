using System.Numerics;
using UnityEditor.Callbacks;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float addSpeed = 10f;


    Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision other)
    {

        Debug.Log("Calling Ball Collision");

        //Get the rigidbody here.
        rb = GetComponent<Rigidbody>();

        UnityEngine.Vector3 velocity = rb.linearVelocity;

        velocity.x += addSpeed;
        velocity.y += addSpeed;

        velocity.x *= -1;
        velocity.y *= -1;
        velocity.z *= -1;

        rb.linearVelocity = velocity;

        // rb.AddForce(velocity, ForceMode.VelocityChange);


        //Add the velocity by addSpeed
        //rigid body.linear velocity

        //times the velocity by -1

        //Set this velocity to the rigidbodies velocity.

        //Increase it's speed if it hits a paddle

        //Find out the angle, and bounce away in the Pong way.
        // other.CompareTag to find if paddle or wall.
    }
}
