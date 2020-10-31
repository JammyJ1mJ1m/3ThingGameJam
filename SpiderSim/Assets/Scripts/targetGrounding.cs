using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetGrounding : MonoBehaviour
{
    public float distance = 100f;

    void LateUpdate()
    {

      
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {

            Vector3 targetLocation = hit.point;

            targetLocation += new Vector3(0, transform.localScale.y / 2, 0);
            
            transform.position = targetLocation;
            
            Debug.DrawLine(transform.position, hit.point, Color.red);
        }
    }
}
