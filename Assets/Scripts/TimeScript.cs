using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {
	
	public float timeLimit = 60.0f; // 10 seconds.
	public void Update()
	{
		// translate object for 10 seconds.
		if(timeLimit > 0) {
			// Decrease timeLimit.
			timeLimit -= Time.deltaTime;
			// translate backward.
			//Debug.Log(timeLimit);
		}
	}
}
