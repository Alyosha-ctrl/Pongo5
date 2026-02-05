using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class paddleControl : MonoBehaviour
{
    //Added To

    public float paddleSpeed = 5;
    public float forceStrength = 50;

    public GameObject lPaddle;
    public GameObject rPaddle;

    public float dashMultiplier = 50;

    bool dash = true;
    bool leftDash = true;

    Rigidbody rb;
    Rigidbody rbLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Chello");
        rb = rPaddle.GetComponent<Rigidbody>();
        rbLeft = lPaddle.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(0f, 0f, paddleSpeed)*Time.deltaTime;
        
        //Do this with inputManager

        
        
        if (Keyboard.current.downArrowKey.isPressed)
        {
            Vector3 force = new Vector3(0f, 0f, forceStrength);
            rb.AddForce(force, ForceMode.VelocityChange);

        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            Vector3 force = new Vector3(0f, 0f, -forceStrength);
            rb.AddForce(force, ForceMode.VelocityChange);
        }
        if (Keyboard.current.spaceKey.isPressed & Keyboard.current.downArrowKey.isPressed & dash)
        {
            Vector3 force = new Vector3(0f, 0f, forceStrength*50);
            rb.AddForce(force, ForceMode.Impulse);
            dash = false;
            Invoke("resetDash", 1f);
            // transform.position+=new Vector3(0f, 0f, paddleSpeed*5);
        }
        if (Keyboard.current.spaceKey.isPressed & Keyboard.current.upArrowKey.isPressed & dash)
        {
            Vector3 force = new Vector3(0f, 0f, -forceStrength*50);
            rb.AddForce(force, ForceMode.Impulse);
            dash = false;
            Invoke("resetDash", 1f);
            // transform.position-=new Vector3(0f, 0f, paddleSpeed*5);
        }

        //Left Controls
        if (Keyboard.current.sKey.isPressed)
        {
            Vector3 force = new Vector3(0f, 0f, forceStrength);
            rbLeft.AddForce(force, ForceMode.VelocityChange);

        }
        if (Keyboard.current.wKey.isPressed)
        {
            Vector3 force = new Vector3(0f, 0f, -forceStrength);
            rbLeft.AddForce(force, ForceMode.VelocityChange);
        }
        if (Keyboard.current.eKey.isPressed & Keyboard.current.sKey.isPressed & leftDash)
        {
            Vector3 force = new Vector3(0f, 0f, forceStrength*50);
            rbLeft.AddForce(force, ForceMode.Impulse);
            leftDash = false;
            Invoke("resetDashLeft", 1f);
            // transform.position+=new Vector3(0f, 0f, paddleSpeed*5);
        }
        if (Keyboard.current.eKey.isPressed & Keyboard.current.wKey.isPressed & leftDash)
        {
            Vector3 force = new Vector3(0f, 0f, -forceStrength*50);
            rbLeft.AddForce(force, ForceMode.Impulse);
            leftDash = false;
            Invoke("resetDashLeft", 1f);
            // transform.position-=new Vector3(0f, 0f, paddleSpeed*5);
        }

        // if (Input.GetButton("DownRight"))
        // {
        //     Vector3 force = new Vector3(0f, 0f, forceStrength);
        //     rb.AddForce(force, ForceMode.VelocityChange);

        // }
        // if (Input.GetButton("UpRight"))
        // {
        //     Vector3 force = new Vector3(0f, 0f, -forceStrength);
        //     rb.AddForce(force, ForceMode.VelocityChange);
        // }
        // if (Input.GetButton("Jump") & Input.GetButton("DownRight") & dash)
        // {
        //     Vector3 force = new Vector3(0f, 0f, forceStrength*50);
        //     rb.AddForce(force, ForceMode.Impulse);
        //     dash = false;
        //     Invoke("resetDash", 1f);
        //     // transform.position+=new Vector3(0f, 0f, paddleSpeed*5);
        // }
        // if (Input.GetButton("Jump") & Input.GetButton("UpRight") & dash)
        // {
        //     Vector3 force = new Vector3(0f, 0f, -forceStrength*50);
        //     rb.AddForce(force, ForceMode.Impulse);
        //     dash = false;
        //     Invoke("resetDash", 1f);
        //     // transform.position-=new Vector3(0f, 0f, paddleSpeed*5);
        // }

        // //Left Controls
        // if (Input.GetButton("DownLeft"))
        // {
        //     Vector3 force = new Vector3(0f, 0f, forceStrength);
        //     rbLeft.AddForce(force, ForceMode.VelocityChange);

        // }
        // if (Input.GetButton("UpLeft"))
        // {
        //     Vector3 force = new Vector3(0f, 0f, -forceStrength);
        //     rbLeft.AddForce(force, ForceMode.VelocityChange);
        // }
        // if (Input.GetButton("DashLeft") & Input.GetButton("DownLeft") & leftDash)
        // {
        //     Vector3 force = new Vector3(0f, 0f, forceStrength*50);
        //     rbLeft.AddForce(force, ForceMode.Impulse);
        //     leftDash = false;
        //     Invoke("resetDashLeft", 1f);
        //     // transform.position+=new Vector3(0f, 0f, paddleSpeed*5);
        // }
        // if (Input.GetButton("DashLeft") & Input.GetButton("UpLeft") & leftDash)
        // {
        //     Vector3 force = new Vector3(0f, 0f, -forceStrength*50);
        //     rbLeft.AddForce(force, ForceMode.Impulse);
        //     leftDash = false;
        //     Invoke("resetDashLeft", 1f);
        //     // transform.position-=new Vector3(0f, 0f, paddleSpeed*5);
        // }
    }

    void resetDash()
    {
        dash = true;
    }

    void resetDashLeft()
    {
        leftDash = true;
    }
}
