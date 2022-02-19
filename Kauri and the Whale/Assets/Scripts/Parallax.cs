using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject PakaiRSR;
    private float length, startpos;
    Camera cam;
    public float parallexEffect;
    void Start()
    {
        cam = Camera.main;
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallexEffect));
        float dist = (cam.transform.position.x * parallexEffect);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
