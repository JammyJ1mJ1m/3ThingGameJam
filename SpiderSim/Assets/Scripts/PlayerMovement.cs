using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -1 * Time.deltaTime * playerSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * -1 * Time.deltaTime * playerSpeed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            //transform.Rotate(0, -2, 0);
            transform.Rotate(0, 75 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -75 * Time.deltaTime, 0);

        }
    }
}
