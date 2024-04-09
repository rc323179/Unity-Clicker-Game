using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float twist;
    public GameObject []plants;
    public bool canClimb = false;
    Rigidbody rb;
    GameObject climber; // for now, climbers and droppers are not used in-game.
    GameObject dropper;
    CameraController cam;
    // Start is called before the first frame update
    void Start()
    {
        // declare vars
        rb = gameObject.GetComponent<Rigidbody>();
        climber = GameObject.FindGameObjectWithTag("Up");
        dropper = GameObject.FindGameObjectWithTag("Down");
        cam = GameObject.FindGameObjectWithTag("Rotate").GetComponent<CameraController>();
    }
    // Update is called once per frame
    void Update()
    {
        // movement
        if (true)
            {
            if (Input.GetKey("w"))
            {
                rb.AddForce(transform.forward*speed*Time.deltaTime,ForceMode.Acceleration);
            }
            if (Input.GetKey("a"))
            {
                transform.Rotate(Vector3.up*-twist*Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                transform.Rotate(Vector3.up*twist*Time.deltaTime);
            }
            if (Input.GetKey("e"))
            {
                cam.RotateUp();
            }
            if (Input.GetKey("r"))
            {
                cam.RotateDown();
            }
        }
        // climbing
        if(Input.GetKey("q") & canClimb)
        {
            // climing area
            transform.position = new Vector3(transform.position.x,transform.position.y+20f*Time.deltaTime,transform.position.z);
            rb.velocity = Vector3.zero;
        }
        else
        {
            climber.transform.position = new Vector3(-2500f,-2000f,-2000f);
            dropper.transform.position = new Vector3(-2000f,-2000f,-2000f);
        }
    }

    public void Grow()
    {
        for (int area = 0; area < plants.Length; area++)
        {
            plants[area].GetComponent<PlantController>().Grow();
        }
    }
}
