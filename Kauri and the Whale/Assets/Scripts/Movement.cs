using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D PlayerRB;
    public float mSpeed = 1;
    public float jumpHeight = 2;
    Vector3 right = new Vector3( -1, 1, 1);
    Vector3 left = new Vector3( 1, 1, 1);

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
            transform.Translate(new Vector3(m,0,0) * mSpeed * Time.deltaTime);
        }
        if(m < 0)
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

    }

    private void FixedUpdate()
    {


        if (Input.GetMouseButton(0))
        {
            CastRay();
        }

    }

    void CastRay()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit)
        {
            Debug.Log(hit.transform.name);
        }
    }
}
