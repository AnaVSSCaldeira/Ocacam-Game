using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using System;

public class TimerSystem : MonoBehaviour
{
    public TextMeshProUGUI txt_timer;
    public float timer = 0f;
    public float minute = 0f;
    public float second = 0f;
    void Awake()
    {
        txt_timer = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer();
    }
    public void updateTimer()
    {
        timer += Time.deltaTime;
        txt_timer.text = ((int)timer).ToString();
        minute = Mathf.FloorToInt(timer / 60); 
        second = Mathf.FloorToInt(timer % 60);
        txt_timer.text = string.Format("{0:00}:{1:00}", minute, second);

    }

    // public string LeadingZero (int n)
    // {
    //     return n.ToString().PadLeft(2, '0');
    // }
}
