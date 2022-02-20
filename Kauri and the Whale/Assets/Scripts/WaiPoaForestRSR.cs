using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaiPoaForestRSR : MonoBehaviour
{
    ReferenceScriptManager rsm;
    GameObject ReferenceObject;
    public Camera cam;

    GameObject Credits;
    Image BlackoutImage;
    public float targetAlpha;
    public float FadeRate;

    //Character things

    GameObject Character;

    void Start()
    {
        ReferenceObject = GameObject.Find("ReferenceScriptHolder");
        rsm = ReferenceObject.GetComponent<ReferenceScriptManager>();

        Character = rsm.Character;
        cam = rsm.cam;
        Credits = rsm.EndScreen;
        BlackoutImage = rsm.BlackoutScreen;
    }

    public void EndGameScree()
    {
        StartCoroutine(EndScreen());
    }

    IEnumerator EndScreen()
    {
        FadeToBlack();
        Character.GetComponent<Movement>().enabled = false;
        yield return new WaitForSeconds(4f);
        Credits.SetActive(true);
        BlackToTransparent();
    }


    public void FadeToBlack()
    {
        targetAlpha = 1.0f;
        StartCoroutine(FadeIn());
    }

    public void BlackToTransparent()
    {
        targetAlpha = 0.0f;
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        Color curColor = BlackoutImage.color;
        while (Mathf.Abs(curColor.a - targetAlpha) > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, FadeRate * Time.deltaTime);
            BlackoutImage.color = curColor;
            yield return null;
        }
    }



}
