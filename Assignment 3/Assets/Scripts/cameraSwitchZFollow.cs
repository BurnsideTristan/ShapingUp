using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitchZFollow : MonoBehaviour
{
    public Camera camera_main;
    public Camera camera_z;

    private void Start()
    {
        camera_main.enabled = true;
        camera_z.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube1" && camera_main.enabled == false && camera_z.enabled == true)
        {
            camera_main.enabled = true;
            Debug.Log("main enabled is true");
            camera_z.enabled = false;
            Debug.Log("cam z false");
        } else if (other.gameObject.name == "Cube1" && camera_main.enabled == true && camera_z.enabled == false)
        {
            camera_main.enabled = false;
            Debug.Log("main cam false");
            camera_z.enabled = true;
            Debug.Log("z cam true");
        }
    }
}
  
