using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public GameObject clockObject;
    private int minutes;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        minutes = clockObject.GetComponent<Clock>().minutes;
        // Reference Clock minute hier && if minute >= 15 start coroutine
        if (minutes == 1) //10
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime); //0, 55, 0
        }
        if (minutes == 15) //30
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime); //0, 145, 0
        }
        if (minutes == 30) //50
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime); //0, 230, 0
        }
        if (minutes == 45) //60
        {
            transform.Rotate(new Vector3(-45, 0, 0) * Time.deltaTime); //-90, 180, 45
        }

    }
}
