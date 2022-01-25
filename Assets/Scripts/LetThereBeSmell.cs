using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetThereBeSmell : MonoBehaviour
{
    public GameObject clockObject;
    private int listLength;
    private bool coroutineOn = false;
    private int minutes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        minutes = clockObject.GetComponent<Clock>().minutes;
        // Reference Clock minute hier && if minute >= 15 start coroutine
        if (minutes >= 30 && !coroutineOn)
        {
            StartCoroutine(StartClouds());
            coroutineOn = true;
        }
    }

    IEnumerator StartClouds()
    {

        listLength = gameObject.transform.childCount;
        for(int i = 0; i < listLength; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
        }
        
    }
}
