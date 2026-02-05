using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public BallController controller;
    void Start()
    {
        Debug.Log("Trigger Born");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if(this.CompareTag("LeftTrigger"))
        {
            //Do a right score increase function
            controller.rightScoreUp();
        }else if (this.CompareTag("RightTrigger"))
        {
            //Do a left score increase function
            controller.leftScoreUp();
            
        }
    }
}
