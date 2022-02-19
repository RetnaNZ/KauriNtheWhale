using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnabler : MonoBehaviour
{
    public ReferenceScriptManager rsm;

    GameObject Character;

    private void Start()
    {
        Character = rsm.Character;
    }

    public void DisableMovement()
    {
        Character.GetComponent<Movement>().enabled = (false);
    }

    public void EnableMovement()
    {
        Character.GetComponent<Movement>().enabled = (true);
    }
}