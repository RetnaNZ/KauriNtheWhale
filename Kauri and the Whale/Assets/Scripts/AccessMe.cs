using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessMe : MonoBehaviour
{
    public GameObject Whiteout;
    Image whiteoutImage;
    public float targetAlpha;
    public float FadeRate;

    // Start is called before the first frame update
    void Start()
    {
        whiteoutImage = Whiteout.GetComponent<Image>();
    }

    public void FadeToWhite()
    {
        targetAlpha = 1.0f;
        StartCoroutine(FadeIn());
    }

    public void WhiteToExposed()
    {
        targetAlpha = 0.0f;
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        Color curColor = whiteoutImage.color;
        while (Mathf.Abs(curColor.a - targetAlpha) > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, FadeRate * Time.deltaTime);
            whiteoutImage.color = curColor;
            yield return null;
        }
    }
}
