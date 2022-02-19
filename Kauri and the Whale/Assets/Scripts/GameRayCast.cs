using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRayCast : MonoBehaviour
{
    Camera cam;
    public GameObject gameplayControllerGO;
    BoatCleanUp boatCleanUp;

    private void Start()
    {
        cam = Camera.main;
        gameplayControllerGO = GameObject.Find("Boat");
        boatCleanUp = gameplayControllerGO.GetComponent<BoatCleanUp>();

    }

    private void Update()
    {
        CastRay();
    }

    void CastRay()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (Input.GetMouseButton(0))
        {

            if (hit)
            {
                if(hit.transform.gameObject.tag == "Interactable")
                {
                    hit.transform.gameObject.transform.position = new Vector3(hit.point.x, hit.point.y, 0);

                    if(Vector3.Distance(gameplayControllerGO.transform.position , new Vector3(hit.point.x, hit.point.y, 0)) < 3)
                    {
                        hit.transform.gameObject.GetComponent<CircleCollider2D>().enabled = false;
                        hit.transform.gameObject.transform.position = gameplayControllerGO.transform.position;
                        hit.transform.parent = gameplayControllerGO.transform;
                        boatCleanUp.PointsCollected += 1;
                    }
                }
            }
        }

    }
}
