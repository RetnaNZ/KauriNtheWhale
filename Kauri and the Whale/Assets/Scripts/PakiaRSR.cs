using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PakiaRSR : MonoBehaviour
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


    public void StartTalking()
    {
        StartCoroutine(startTalkingCoroutine());
    }


    public void FishingTalking()
    {
        StartCoroutine(finishTalkingCoroutine());
    }


    IEnumerator finishTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled = false;
        yield return new WaitForSeconds(3f);
    }

    IEnumerator startTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled= false;
        yield return new WaitForSeconds(3f);
    }

}
