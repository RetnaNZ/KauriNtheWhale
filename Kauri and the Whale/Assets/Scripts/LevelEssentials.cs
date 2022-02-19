using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEssentials : MonoBehaviour
{
    public GameObject LevelEssentialsPrefab;

    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("LevelEssential").Length == 0)
        {
            Instantiate(LevelEssentialsPrefab);
        }else
        {
            Debug.Log("Already have a level essestial");
        }
    }

}
