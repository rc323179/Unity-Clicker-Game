using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float yaw;
    private float x = 0f;
    public void RotateUp()
    {
        if(x >= -90f)
        {
            transform.Rotate(-yaw*Time.deltaTime, 0f, 0f);
            x += -yaw*Time.deltaTime;
        }
    }
    public void RotateDown()
    {
        if(x <= 90f)
        {

            x += yaw*Time.deltaTime;
            transform.Rotate(yaw*Time.deltaTime, 0f, 0f);
        }
    }
}
