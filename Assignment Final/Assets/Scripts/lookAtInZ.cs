using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtInZ : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 tempVec3 = new Vector3();

    void LateUpdate()
    {
        tempVec3.z = this.transform.position.z;
        tempVec3.y = this.transform.position.y;
        tempVec3.x = playerTransform.position.x;
        this.transform.position = tempVec3;
    }
}
