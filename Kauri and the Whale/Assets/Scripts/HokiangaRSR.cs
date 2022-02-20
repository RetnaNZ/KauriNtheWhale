using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HokiangaRSR : MonoBehaviour
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
        Character.GetComponent<Animator>().SetBool("Walking", false);
        StartCoroutine(startTalkingCoroutine());
    }

    public void FinishTalking()
    {
        StartCoroutine(finishTalkingCoroutine());
    }

    IEnumerator finishTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled = true;
        yield return new WaitForSeconds(3f);
    }

    IEnumerator startTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled= false;
        yield return new WaitForSeconds(3f);
    }

}
