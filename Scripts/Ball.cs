using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 bounceLocation;
    private float lastFired;
    public float fireRate = 5f;
    private Ray ray;
    public ComputerPaddle cp;


    // Start is called before the first frame update
    void Start()
    {
        Launch();
        lastFired = 0;
    }

    private void Update()
    {
        if (Time.time - lastFired > fireRate)
        {
            lastFired = Time.time;
            Debug.Log("Fired!!!");
            calculatebounce(new Vector2(transform.position.x, transform.position.y), rb.velocity);
        }


    }

    private void calculatebounce(Vector2 point, Vector2 originalDirection)
    {
        ray = new Ray(point, originalDirection);
        for (int x = 0; x < 5; x++)
        {
            Debug.Log("CAlculating!");
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 50, 1 << 3);
            if (hit)
            {
                Debug.DrawRay(ray.origin, ray.direction, Color.red);
                ray = new Ray(hit.point, Vector2.Reflect(ray.direction, hit.normal));

                if (hit.collider.tag == "goal")
                {
                    bounceLocation = hit.point;
                    Debug.Log("GOAL");
                    break;
                }
            }
        }
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void AddForce(Vector2 force)
    {
        rb.velocity += force / 4;
        cp.speed += 0.15f;
    }
}
