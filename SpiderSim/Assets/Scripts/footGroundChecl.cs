using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footGroundChecl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    void FixedUpdate()
    {
        RaycastHit hit = new RaycastHit();

        Vector3 fwd = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, fwd, out hit))
        print("foot sees the floor");
        print(hit.point);

        Debug.DrawLine(transform.position, hit.point, Color.red);
        // transform.position = new Vector3(transform.position.x, ControllerColliderHit., transform.position.z);


    }
}
