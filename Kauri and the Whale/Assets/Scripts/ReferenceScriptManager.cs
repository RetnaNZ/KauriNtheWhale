using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceScriptManager : MonoBehaviour
{
    static ReferenceScriptManager referenceScriptManager;

    public GameObject Character;
    public Camera cam;

    public GameObject WhiteoutPanel;

    public bool BoatGameCompleted = false;

    private void Awake()
    {
        referenceScriptManager = this;
        cam = Camera.main;
    }

    void Start()
    {
        Character = GameObject.Find("Character");
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
        Character.GetComponent<Movement>().enabled = true;
        yield return new WaitForSeconds(3f);
    }

    IEnumerator startTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled = false;
        yield return new WaitForSeconds(3f);
    }

}
