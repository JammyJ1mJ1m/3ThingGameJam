using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footGroundChecl : MonoBehaviour
{
    /*
     * The wanted length for the Raycast.
     */
    public float distance = 100f;

    public Transform footIK;


    
    void LateUpdate()
    {

        Vector3 fromPosition = transform.position;
        Vector3 toPosition = footIK.transform.position;
        Vector3 direction = toPosition - fromPosition;
        /*
         * Create the hit object.
         */
        RaycastHit hit;
        /*
         * Cast a Raycast.
         * If it hits something:
         */
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            /*
             * Set the target location to the location of the hit.
             */
            Vector3 targetLocation = hit.point;
            /*
             * Modify the target location so that the object is being perfectly aligned with the ground (if it's flat).
             */
            targetLocation += new Vector3(0, transform.localScale.y / 2, 0);
            /*
             * Move the object to the target location.
             */
            if (direction.magnitude <= 0.5f)
            {
                transform.position = targetLocation;

            }
            else
            {
                Debug.Log("the distance is greater than 2");
                transform.position = toPosition;
            }

            Debug.DrawLine(transform.position, hit.point, Color.red);
        }

        Debug.Log(direction);

        /*
        
        */
    }
}



