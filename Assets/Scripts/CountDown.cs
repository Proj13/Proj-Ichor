using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	float timeRemaining = 60.0f;
	public GUIStyle textStyle;

	void Update () {
		timeRemaining -= Time.deltaTime;
	}
	
	void OnGUI(){
		//textStyle.normal.textColor = Color.white;
		//textStyle.font = (Font)Resources.Load ("CHILLER");
		//textStyle.fontSize = 24;

		if(timeRemaining > 0){
			GUI.Label(new Rect(Screen.width/2.06f, Screen.height/72f, 200, 100), 
			          "Time Remaining : "+timeRemaining, textStyle);
		}
		else{
			GUI.Label(new Rect(600, 100, 200, 100), "Time's Up");
		}
	}
}
