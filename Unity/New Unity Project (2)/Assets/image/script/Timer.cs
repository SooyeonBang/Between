using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float TotalTime = 0f;
    public bool timerOn = true;


    private int minute = 0;
    private int second = 0;
    private int tic = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            TotalTime += Time.deltaTime;

        }
        this.GetComponent<Text>().text = TimerCalc();


    }
    private string TimerCalc()
    {
        tic = (int)((TotalTime % 1) * 100);
        second = (int)TotalTime % 60;
        minute = (int)TotalTime / 60;
        return minute + ":" + second + ":" + tic;

        
    }

}
