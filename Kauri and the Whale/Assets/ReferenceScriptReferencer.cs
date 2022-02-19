using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceScriptReferencer : MonoBehaviour
{
    ReferenceScriptManager rsm;
    GameObject ReferenceObject;

    //Character things

    GameObject Character;

    void Start()
    {
        ReferenceObject = GameObject.Find("ReferenceScriptHolder");
        rsm = ReferenceObject.GetComponent<ReferenceScriptManager>();

        Character = rsm.Character;
    }

    void Update()
    {

    }


    public void StartBoatGame()
    {
        rsm.Character.GetComponent<Movement>().enabled= false;
        rsm.Character.GetComponent<GameRayCast>().enabled = true;
    }

    public void FinishBoatGame()
    {
        rsm.Character.GetComponent<Movement>().enabled = true;
        rsm.Character.GetComponent<GameRayCast>().enabled = false;

    }
}
