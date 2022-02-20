using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaipoaLoad : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }


}
