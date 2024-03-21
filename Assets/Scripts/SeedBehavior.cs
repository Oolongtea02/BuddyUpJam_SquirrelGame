using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBehavior : MonoBehaviour
{
	public float speed = 4.5f;
    private Vector2 direction = Vector2.right;

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }
    // Update is called once per frame
    private void Update()
    {
       transform.position += (Vector3)direction * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if(collision.FindGameObjectsWithTag("Finish"))
        {
            GoalAnim.SetTrigger("Goal");
        }*/
    	Destroy(gameObject);
    }
}
