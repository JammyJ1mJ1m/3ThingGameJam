using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_Cast : MonoBehaviour
{
    public float distance = 100f;
    private LayerMask LayerGround;

    private void Start()
    {
        LayerGround = LayerMask.NameToLayer("ground");
    }
    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            if (hit.transform.gameObject.layer == LayerGround)
            {
                Vector3 targetLocation = hit.point;

                targetLocation += new Vector3(0, transform.localScale.y / 2f, 0);

                transform.position = targetLocation;

                Debug.DrawLine(transform.position, hit.point, Color.red);
            }

            
        }
    }
    
}
