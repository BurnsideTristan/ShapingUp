using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{
    public GameObject thePlayer;

    void Update()
    {
        transform.LookAt(thePlayer.transform);
    }
}
