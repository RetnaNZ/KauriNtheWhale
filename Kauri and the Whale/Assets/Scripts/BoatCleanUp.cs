using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCleanUp : MonoBehaviour
{
    Animator gameplayAnim;
    public int PointsNeeded = 3;
    public int PointsCollected = 0;

    public GameObject boatGameTrigger;
    public ReferenceScriptReferencer rsr;

    private void Start()
    {
        gameplayAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(PointsCollected == PointsNeeded)
        {
            gameplayAnim.SetTrigger("Victory");
            boatGameTrigger.SetActive(false);
            rsr.FinishBoatGame();
            PointsCollected = 0;

        }
    }
}
