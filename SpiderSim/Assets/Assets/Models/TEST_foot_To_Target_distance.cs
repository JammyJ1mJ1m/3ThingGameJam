using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_foot_To_Target_distance : MonoBehaviour
{
    public Transform footTarget;
    public GameObject oppositeLeg;


    void Update()
    {
        float dist = Vector3.Distance(footTarget.position, transform.position);

        if (dist > .75f)
        {
            Debug.LogWarning("Greater than 1.5");
            //transform.position = Vector3.Lerp(this.transform.position, footTarget.position, Time.deltaTime / 2);
            transform.position = footTarget.position; // Vector3.Lerp(transform.position, footTarget.position, 5 * Time.deltaTime);
            if (Vector3.Distance( transform.position, footTarget.position) < .3f)
            {
                Debug.LogWarning("Planted");
            }
        }
    }
}
