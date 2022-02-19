using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
    public GameObject focusedGO;
    public bool onStartDisable;
    public bool onStartEnabled;
    public bool onStartFocusedDisabled;
    public bool onStartFocusedEnabled;

    private void Start()
    {
        if (onStartDisable)
        {
            turnOffTHISGO();
        }

        if (onStartEnabled)
        {
            turnOnTHISGO();
        }

        if (onStartFocusedDisabled)
        {
            turnOffFOCUSEDGO();
        }

        if (onStartFocusedEnabled)
        {
            turnOnFOCUSEDGO();
        }
    }

    public void turnOnFOCUSEDGO()
    {
        focusedGO.SetActive(true);
    }

    public void turnOffFOCUSEDGO()
    {
        focusedGO.SetActive(false);
    }

    public void turnOnTHISGO()
    {
        gameObject.SetActive(true);
    }

    public void turnOffTHISGO()
    {
        gameObject.SetActive(false);
    }

}
