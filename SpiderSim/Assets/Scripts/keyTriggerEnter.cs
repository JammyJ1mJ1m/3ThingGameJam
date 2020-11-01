using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class keyTriggerEnter : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        //if (dataFromCollision.gameObject.tag == "key")
        //{
            Debug.Log("you triggered the key");
        SceneManager.LoadScene(sceneBuildIndex: 0);


        //}
    }

}
