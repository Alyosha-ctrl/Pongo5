using TMPro;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;


public class BallController : MonoBehaviour
{

    public GameObject ballPrefab;
    public float spawnRange = 0;

    public GameObject moon;

    public TextMeshProUGUI leftScoreText;

    public TextMeshProUGUI rightScoreText;

    GameObject currentBall;

    int leftScore = 0;
    int rightScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn_ball_left();
    }

    // Update is called once per frame
    void Update()
    {
        //Set Up BallCollision Checking to create the fancy math bouncing instead of physics bouncing
        //Also increase speed when it touches it
        //Also make it more white for like .25 seconds when it collides.

        //check if the ball is past a certain point, if so add to the score
        //If one score is 11 than another display a success message.
        //If left ball wins Make the moon move up and down in happyness.
        //If right ball wins delete the moon.

        // if(currentBall != null & currentBall.transform.position.x > 11)
        // {
        //     rightScore += 1;
        //     string scoreString = $"Score: {rightScore}";
        //     rightScoreText.text = scoreString;
        //     Destroy(currentBall);
        //     Invoke("spawn_ball_left", 1f);
        // }
        // else if(currentBall != null & currentBall.transform.position.x < -11)
        // {
        //     leftScore += 1;
        //     string scoreString = $"Score: {leftScore}";
        //     leftScoreText.text = scoreString;
        //     Destroy(currentBall);
        //     Invoke("spawn_ball_right", 1f);
        // }


        if(leftScore == 11)
        {
            Debug.Log("Left Paddle Has Won, Moon Saved");
            rightScoreText.text = "Left Paddle Has Won, Moon Saved";
            //Delete The Ball
            //Bring up the first screen and reset everything.
            Destroy(currentBall);
            leftScore = 0;
            rightScore = 0;
        }
        else if (rightScore == 11)
        {
            Debug.Log("Right Paddle Has Won, Moon Destroyed");
            rightScoreText.text = "Right Paddle Has Won, Moon Destroyed";
            Destroy(currentBall);
            Destroy(moon);
            leftScore = 0;
            rightScore = 0;
            //Delete The Ball
            //Delete The Moon
            //Bring up the first screen and reset everything.
        }
    }

    void spawn_ball_left()
    {
        Transform myTransform = GetComponent<Transform>();
        UnityEngine.Vector3 newPos = new UnityEngine.Vector3( 
                myTransform.position.x + Random.Range(spawnRange*-1,spawnRange), 
                myTransform.position.y + Random.Range(0,spawnRange), 
                myTransform.position.z);
        GameObject newBall = Instantiate(ballPrefab, newPos, UnityEngine.Quaternion.identity);
        currentBall = newBall;
        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(50, 0f, Random.Range(spawnRange*-10,spawnRange*10));
        rb.AddForce(force, ForceMode.Impulse);
    }

    void spawn_ball_right()
    {
        Transform myTransform = GetComponent<Transform>();
        UnityEngine.Vector3 newPos = new UnityEngine.Vector3( 
                myTransform.position.x + Random.Range(spawnRange*-1,spawnRange), 
                myTransform.position.y + Random.Range(0,spawnRange), 
                myTransform.position.z);
        GameObject newBall = Instantiate(ballPrefab, newPos, UnityEngine.Quaternion.identity);
        currentBall = newBall;
        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(-50, 0f, Random.Range(spawnRange*-10,spawnRange*10));
        rb.AddForce(force, ForceMode.Impulse);
    }

    public void leftScoreUp()
    {
        leftScore += 1;
        string scoreString = $"Score: {leftScore}";
        leftScoreText.text = scoreString;
        Destroy(currentBall);
        Invoke("spawn_ball_right", 3f);
    }

    public void rightScoreUp()
    {
        rightScore += 1;
        string scoreString = $"Score: {rightScore}";
        rightScoreText.text = scoreString;
        Destroy(currentBall);
        Invoke("spawn_ball_left", 3f);
    }
}
