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

    public void StartBoatGame()
    {
        rsm.Character.GetComponent<Movement>().enabled = false;
        //StartCoroutine(gameIntro());
    }

    public void FishingTalking()
    {
        //StartCoroutine(fishishTalking());
    }

    public void FinishBoatGame()
    {
        rsm.Character.GetComponent<Movement>().enabled = true;
        rsm.Character.GetComponent<GameRayCast>().enabled = false;
        rsm.BoatGameCompleted = true;
    }

    //IEnumerator gameIntro()
    //{
    //    whaleOutOfWater = Whale.transform.position + new Vector3(0, 4, 0);
    //    Whale.transform.GetChild(0).transform.gameObject.SetActive(true);
    //    moveWhale = true;
    //    yield return new WaitForSeconds(3f);
    //    moveWhale = false;
    //}

    //IEnumerator fishishTalking()
    //{
    //    whaleOutOfWater = Whale.transform.position + new Vector3(0, -4, 0);
    //    Whale.transform.GetChild(0).transform.gameObject.SetActive(false);

    //    moveWhale = true;
    //    yield return new WaitForSeconds(3f);
    //    moveWhale = false;

    //    rsm.Character.GetComponent<GameRayCast>().enabled = true;
    //}

}
