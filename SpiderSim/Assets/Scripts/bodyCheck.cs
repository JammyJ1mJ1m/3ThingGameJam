using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyCheck : MonoBehaviour
{
    void LateUpdate()
    {/*
        RaycastHit hit;
        
         * Cast a Raycast.
         * If it hits something:
         
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            
             * Set the target location to the location of the hit.
             
            Vector3 targetLocation = hit.point;
            
             * Modify the target location so that the object is being perfectly aligned with the ground (if it's flat).
             
            targetLocation += new Vector3(0, transform.localScale.y / 2, 0);
            
             * Move the object to the target location.
             
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
            */
        }


    }
