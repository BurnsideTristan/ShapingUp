using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Vector3 firstPerson;
    bool isFirstPerson;

    private void Start()
    {
        offset = transform.position - player.transform.position;
        firstPerson = transform.position;
        isFirstPerson = false;
    }

    private void LateUpdate()
    {
        if (isFirstPerson) {
            transform.position = player.transform.position;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }

        //transform.position = player.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.F)){
            if(isFirstPerson == false)
            {
                isFirstPerson = true;
            }
            else
            {
                isFirstPerson = false;
            }
        }

    }



    /*public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void Update ()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = desiredPosition;

        transform.LookAt(target);
    }*/

}
