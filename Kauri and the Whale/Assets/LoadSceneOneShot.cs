using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOneShot : MonoBehaviour
{
    public Transform player;
    float distanceToLoad;
    public float loadDistance = 15;

    public int sceneIndexToLoad;

    public bool visualDebug = true;

    private void OnDrawGizmos()
    {
        if (visualDebug)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, loadDistance);
        }
    }

    private void Update()
    {

        distanceToLoad = Vector3.Distance(player.position, transform.position);

        if (distanceToLoad < loadDistance)
        {
            SceneManagerController.smc.LoadSceneAt(sceneIndexToLoad);
        }
        else
        {
            SceneManagerController.smc.UnloadSceneAt(sceneIndexToLoad);
        }


    }

}
