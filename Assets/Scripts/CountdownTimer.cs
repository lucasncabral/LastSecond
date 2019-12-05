using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text secondsText;
    [SerializeField] Text milisecondsText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;    
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if(currentTime <= 0)
        {
            secondsText.text = "0";
            milisecondsText.text = ".000";
            return;
        }
        secondsText.text = ((int) currentTime).ToString();
        milisecondsText.text = "." + (currentTime - Math.Truncate(currentTime)).ToString().Substring(2, 3);
    }
}
