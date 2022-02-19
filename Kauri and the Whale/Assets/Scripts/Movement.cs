using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D PlayerRB;
    public float mSpeed = 10;
    public float mouseMSpeed = 6;
    public float jumpHeight = 2;
    Vector3 right = new Vector3(-1, 1, 1);
    Vector3 left = new Vector3(1, 1, 1);

    public float startTime;
    public bool mouseClicked = false;

    public float journeyDist;
    public Vector3 travelpoint;
    public Vector3 startPosition;
    Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float m = Input.GetAxis("Horizontal");
        if (m != 0)
        {
            mouseClicked = false;
            transform.Translate(new Vector3(m, 0, 0) * mSpeed * Time.deltaTime);
        }
        if (m < 0)
        {
            transform.localScale = right;
        }
        else
        {
            transform.localScale = left;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRB.AddForce(Vector2.up * jumpHeight * 100);
        }


        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            if (hit)
            {
                travelpoint = new Vector3(hit.point.x, transform.position.y, 0);
                journeyDist = Vector3.Distance(startPosition, travelpoint);
                transform.position = Vector3.MoveTowards(transform.position, travelpoint, mouseMSpeed * Time.deltaTime);

                if(hit.point.x < transform.position.x)
                {
                    transform.localScale = right;
                }
                else
                {
                    transform.localScale = left;
                }
            }
        }

    }



}
