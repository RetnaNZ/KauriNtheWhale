using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    private static SingletonManager _instance;
    public static SingletonManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError(message: "SingletonManager is null");
            }
            return _instance;
        }
    }
    public static SceneManagerController sceneManagerController;
    public GameObject sceneManagerGO;

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        sceneManagerController = sceneManagerGO.GetComponent<SceneManagerController>();
    }

}
