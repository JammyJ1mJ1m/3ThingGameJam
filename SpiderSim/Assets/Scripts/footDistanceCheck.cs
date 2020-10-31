using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footDistanceCheck : MonoBehaviour
{
    public Transform footIK;
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 fromPosition = transform.position;
        Vector3 toPosition = footIK.transform.position;
        Vector3 direction = toPosition - fromPosition;

        RaycastHit hit;
        //Debug.DrawLine(transform.position, hit.point, Color.red);

        Debug.Log(direction);


        if (direction.magnitude > 2f)
        {
            Debug.Log("the distance is greater than 2");
            footIK.position = toPosition;
        }

        if (Physics.Raycast(transform.position, toPosition, out hit))
        {
            Debug.Log("Hit point is " + hit);

        }

        Debug.DrawLine(toPosition, hit.point, Color.red);

    }
}
