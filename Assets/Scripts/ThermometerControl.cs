using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermometerControl : MonoBehaviour
{
    private float temperature = 20.7f;
    public GameObject clockObject;
    private int minutes;
    private bool coroutineOn = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Starts automatically -> we like to boil frogs slowly ;-)
        minutes = clockObject.GetComponent<Clock>().minutes;
        // Reference Clock minute hier && if minute >= 15 start coroutine
        if (minutes >= 1 && !coroutineOn)
        {
            StartCoroutine(heating());
            coroutineOn = true;
        }
    }

    IEnumerator heating()
    {

        for(int i = 0; i < 120; i++)
        {
            // increase temperature
            temperature += 0.1f;

            // Change text of thermometer
            GetComponent<TextMesh>().text = temperature.ToString("F1");

            //wait a second
            yield return new WaitForSeconds(1);
        }
    }
}
