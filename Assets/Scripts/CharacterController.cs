using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float acceleration = 30.0f;
    SpriteRenderer sprite;

    public RaycastShoot SeedPrefab;
    public Transform LaunchOffset;
    
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("up"))
            {
            m_Rigidbody.AddForce(transform.up * acceleration);
        }
        if (Input.GetKey("down"))
        {
            m_Rigidbody.AddForce(transform.up * -acceleration);
        }
        if (Input.GetKey("right"))
        {
            m_Rigidbody.AddForce(transform.right * acceleration);
            if (!Input.GetKey("left"))
            { sprite.flipX = false; }
        }
        if (Input.GetKey("left"))
        {
            m_Rigidbody.AddForce(transform.right * -acceleration);
            if (!Input.GetKey("right"))
            { sprite.flipX = true; }
        }

        if (Input.GetKeyDown("space"))
        {
            Instantiate(SeedPrefab, LaunchOffset.position, transform.rotation);
            Debug.Log("space key was pressed");
        }
    }
}

