using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;

public class timer : MonoBehaviour
{
	public Text timerText;
	private float startTime;
	private float maxTime;
	public bool reset = false;

    // Start is called before the first frame update
    void Start()
    {
		startTime = Time.time;
		maxTime = 15;        
    }

    // Update is called once per frame
    void Update()
    {	
		print(t.ToString("f1"));
		if (reset == true){
			reset = false;
			startTime = Time.time;
		}
		float elapsed = Time.time - startTime;
		float t = Math.Max(maxTime - elapsed, 0);
		timerText.text = t.ToString("f1");
    }
}
