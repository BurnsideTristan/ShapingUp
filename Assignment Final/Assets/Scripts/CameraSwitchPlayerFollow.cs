using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchPlayerFollow : MonoBehaviour
{
    public Camera camera_z;
    public Camera camera_follow;

    private void Start()
    {
        camera_follow.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube2" && camera_z.enabled == false)
        {
            camera_z.enabled = true;
            camera_follow.enabled = false;
            Debug.Log("z enabled");
        } else if (other.gameObject.name == "Cube2")
        {
            camera_z.enabled = false;
            camera_follow.enabled = true;
            Debug.Log("z disabled");
        }


    }
}
