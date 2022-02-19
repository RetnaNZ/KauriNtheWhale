using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceScriptManager : MonoBehaviour
{
    static ReferenceScriptManager referenceScriptManager;

    public GameObject Character;

    private void Awake()
    {
        referenceScriptManager = this;   
    }

    void Start()
    {
        Character = GameObject.Find("Character");
    }
}
