using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorCheckRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Rigidbody rb;
    public Transform hoverpoint;
    public Transform spider;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, fwd, 0.5f))
            spider.position = new Vector3(spider.position.x, hoverpoint.position.y, spider.position.z);
            print("There is something in below of the object!");

    }
}
