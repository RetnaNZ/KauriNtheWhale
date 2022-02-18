using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnter : MonoBehaviour
{
    public UnityEvent triggerEnter = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            triggerEnter.AddListener(myAction);
            triggerEnter.Invoke();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggerEnter.RemoveAllListeners();
    }

    void myAction()
    {
        Debug.Log("Hello, Im listening");
    }
}
