using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCoroutine : MonoBehaviour
{
    public float disableAfterTimer = 1f;

    void Start()
    {
        StartCoroutine(disableMyself());
    }

    IEnumerator disableMyself()
    {
        yield return new WaitForSeconds(disableAfterTimer);
        transform.gameObject.SetActive(false);
    }
}
