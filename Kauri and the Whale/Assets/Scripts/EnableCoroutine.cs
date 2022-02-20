using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCoroutine : MonoBehaviour
{
    public GameObject FocusedGO;
    public float EnableAfterTimer = 1f;
    public bool triggerTimerOnWake;

    private void Start()
    {
        if (triggerTimerOnWake)
        {
            enableFocused();
        }
    }
    public void enableFocused()
    {
        StartCoroutine(enableFocusedCoroutine());
    }

    IEnumerator enableFocusedCoroutine()
    {
        yield return new WaitForSeconds(EnableAfterTimer);
        FocusedGO.SetActive(true);
    }
}
