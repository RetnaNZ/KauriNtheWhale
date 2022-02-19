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


}
