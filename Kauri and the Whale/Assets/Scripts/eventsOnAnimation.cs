using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class eventsOnAnimation : MonoBehaviour
{
    public GameObject spriteOne;
    public GameObject spriteTwo;
    public float timeBetweenSwitch = 2f;

    private void Start()
    {
    }

    public void swapSprites(GameObject s1, GameObject s2)
    {

    }
    
    IEnumerator swapSprites()
    {
        spriteOne.SetActive(false);
        yield return new WaitForSeconds(timeBetweenSwitch);
        spriteTwo.SetActive(true);
    }
}
