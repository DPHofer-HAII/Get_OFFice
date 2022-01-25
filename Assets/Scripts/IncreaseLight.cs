using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseLight : MonoBehaviour
{
    private Light objectLight;
    public GameObject clockObject;
    public int minutes = 0;
    private bool coroutineOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        minutes = clockObject.GetComponent<Clock>().minutes;
        // Reference Clock minute hier && if minute >= 15 start coroutine
        if (minutes >= 15 && !coroutineOn)
        {
            StartCoroutine(ChangeIntensityCoroutine());
            coroutineOn = true;
        }
    }

    private IEnumerator ChangeIntensityCoroutine()
    {
        objectLight = GetComponent<Light>();

        while (true)
        {
            objectLight.intensity += 0.01f;
            yield return new WaitForSeconds(1);
        }
    }
}
