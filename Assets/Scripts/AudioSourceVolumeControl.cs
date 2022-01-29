using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceVolumeControl : MonoBehaviour
{
    private AudioSource MyAudioSource;
    public GameObject clockObject;
    public int minutes = 0;
    private bool coroutineOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        minutes = clockObject.GetComponent<Clock>().minutes;
        // Reference Clock minute hier && if minute >= 15 start coroutine
        if (minutes >= 45 && !coroutineOn)
        {
            StartCoroutine(ChangeVolumeCoroutine());
            coroutineOn = true;
        }
    }

    private IEnumerator ChangeVolumeCoroutine()
    {
        MyAudioSource = GetComponent<AudioSource>();

        while (MyAudioSource.volume < 1.0f)
        {
            MyAudioSource.volume += 0.001f;
            yield return new WaitForSeconds(1);
        }
    }
}
