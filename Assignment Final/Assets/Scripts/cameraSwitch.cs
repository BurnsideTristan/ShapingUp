using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{

    public Camera camera_main;
    public Camera camera_z;
    public Camera camera_follow;

    // Start is called before the first frame update
    void Start()
    {
        camera_main.enabled = true;
        camera_z.enabled = false;
        camera_follow.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube1" && camera_main.enabled == false)
        {
            camera_main.enabled = true;
            camera_z.enabled = false;
            camera_follow.enabled = false;
            Debug.Log("main enabled");
        }
        else if (other.gameObject.name == "Cube1")
        {
            camera_main.enabled = false;
            camera_z.enabled = true;
            camera_follow.enabled = false;
            Debug.Log("main disabled");
        }

        if (other.gameObject.name == "Cube2" && camera_z.enabled == false)
        {
            camera_z.enabled = true;
            camera_follow.enabled = false;
            camera_main.enabled = false;
            Debug.Log("z enabled");
        }
        else if (other.gameObject.name == "Cube2")
        {
            camera_z.enabled = false;
            camera_follow.enabled = true;
            camera_main.enabled = false;
            Debug.Log("z disabled");
        }
    }

}
