using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float acceleration = 30.0f;
    SpriteRenderer sprite;

    public SeedBehavior SeedPrefab;
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
            SeedBehavior seed = Instantiate(SeedPrefab, LaunchOffset.position, transform.rotation);

            //Determine the direction based on input keys
            Vector2 direction = Vector2.right;
            if (Input.GetKey("up"))
           	{
           		direction = Vector2.up;
           	}
           	else if (Input.GetKey("down"))
           	{
           		direction = -Vector2.up;
           	}
           	else if (Input.GetKey("right"))
           	{
           		direction = Vector2.right;
           	}
           	else if (Input.GetKey("left"))
           	{
           		direction = -Vector2.right;
           	}

           	//Set the direction of the seed
           	seed.SetDirection(direction);

           	Debug.Log("space key was pressed");
        }
    }
}

