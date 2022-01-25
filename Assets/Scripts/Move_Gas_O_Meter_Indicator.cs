using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Gas_O_Meter_Indicator : MonoBehaviour
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
        if (minutes == 30)
        {
            transform.localPosition = new Vector3(2.622f, 1.488f, 2.45f);
        }
        if (minutes == 45)
        {
            transform.localPosition = new Vector3(2.622f, 1.506f, 2.683f);
        }
        if (minutes == 60)
        {
            transform.localPosition = new Vector3(2.622f, 1.517f, 2.912f);
        }

    }

}
