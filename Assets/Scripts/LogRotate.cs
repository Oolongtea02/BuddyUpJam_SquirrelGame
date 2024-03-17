using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0, 0, 25 * Time.deltaTime);
            Debug.Log("r key was pressed");
        }
       
    }
}
