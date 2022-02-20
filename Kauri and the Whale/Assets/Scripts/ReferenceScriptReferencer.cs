using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ReferenceScriptReferencer : MonoBehaviour
{
    ReferenceScriptManager rsm;
    GameObject ReferenceObject;

    public GameObject Whale;

    Vector3 whaleOutOfWater;
    bool moveWhale = false;

    //Character things

    GameObject Character;
    public GameObject BoatGameObjects;

    Camera cam;
    public Animator camAnimator;

    void Start()
    {
        ReferenceObject = GameObject.Find("ReferenceScriptHolder");
        rsm = ReferenceObject.GetComponent<ReferenceScriptManager>();

        Character = rsm.Character;
        cam = rsm.cam;

        if (rsm.BoatGameCompleted)
        {
            BoatGameObjects.SetActive(false);
        }
        else
        {
            BoatGameObjects.SetActive(true);
        }

    }

    void Update()
    {
        if(moveWhale == true)
        {
            Whale.transform.position = (Vector3.Lerp(Whale.transform.position, whaleOutOfWater, .025f));
        }
    }


    public void StartBoatGame()
    {
        rsm.Character.GetComponent<Movement>().enabled= false;
        StartCoroutine(gameIntro());
    }

    public void FishingTalking()
    {
        StartCoroutine(fishishTalking());
    }

    public void FinishBoatGame()
    {
        rsm.Character.GetComponent<Movement>().enabled = true;
        rsm.Character.GetComponent<GameRayCast>().enabled = false;
        camAnimator.SetTrigger("camZoomIn");

        rsm.BoatGameCompleted = true;
    }

    IEnumerator gameIntro()
    {
        camAnimator = cam.GetComponent<CinemachineBrain>().ActiveVirtualCamera.VirtualCameraGameObject.GetComponent<Animator>();
        camAnimator.SetTrigger("camZoomOut");
        yield return new WaitForSeconds(3f);
        whaleOutOfWater = Whale.transform.position + new Vector3(0, 4, 0);
        Whale.transform.GetChild(0).transform.gameObject.SetActive(true);
        moveWhale = true;
        yield return new WaitForSeconds(3f);
        moveWhale = false;
    }

    IEnumerator fishishTalking()
    {
        whaleOutOfWater = Whale.transform.position + new Vector3(0, -4, 0);
        Whale.transform.GetChild(0).transform.gameObject.SetActive(false);

        moveWhale = true;
        yield return new WaitForSeconds(2f);
        moveWhale = false;

        rsm.Character.GetComponent<GameRayCast>().enabled = true;
    }


    public void startTalking()
    {
        StartCoroutine(startTalkingCoroutine());
    }
    IEnumerator startTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled = false;
        yield return new WaitForSeconds(3f);
    }

    public void finishTalking()
    {
        StartCoroutine(finishTalkingCoroutine());

    }
    IEnumerator finishTalkingCoroutine()
    {
        Character.GetComponent<Movement>().enabled = true;
        yield return new WaitForSeconds(3f);
    }

}
