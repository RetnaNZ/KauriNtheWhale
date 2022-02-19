using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaiPoaForestRSR : MonoBehaviour
{
    ReferenceScriptManager rsm;
    GameObject ReferenceObject;
    public Camera cam;

    //Character things

    GameObject Character;

    void Start()
    {
        ReferenceObject = GameObject.Find("ReferenceScriptHolder");
        rsm = ReferenceObject.GetComponent<ReferenceScriptManager>();

        Character = rsm.Character;
        cam = rsm.cam;

    }


}
