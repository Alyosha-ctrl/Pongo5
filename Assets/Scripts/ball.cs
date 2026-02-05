using System.Numerics;
using UnityEditor.Callbacks;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float addSpeed = .1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnCollisionEnter(Collision other)
    {
        //Get the rigidbody here.
        
        UnityEngine.Vector3 velocity = new UnityEngine.Vector3(0f, addSpeed, 0f);

        //Add the velocity by addSpeed
        //rigid body.linear velocity

        //times the velocity by -1

        //Set this velocity to the rigidbodies velocity.

        //Increase it's speed if it hits a paddle

        //Find out the angle, and bounce away in the Pong way.
        // other.CompareTag to find if paddle or wall.
    }
}
