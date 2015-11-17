using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class countDown_v002 : MonoBehaviour {
	
	Text timer;
	public float timeRemaining = 60.0f;
	//public GUIStyle textStyle;

	void Start(){
		timer = GetComponent<Text> ();
	}
	void Update () {
		timeRemaining -= Time.deltaTime;
	}
	
	void OnGUI(){
		//textStyle.normal.textColor = Color.white;
		//textStyle.font = (Font)Resources.Load ("CHILLER");
		//textStyle.fontSize = 24;
		
		if(timeRemaining > 0){
			timer.text = "Timer: " + (int)timeRemaining;
			//GUI.Label(new Rect(Screen.width/2.06f, Screen.height/72f, 200, 100), "Time Remaining : "+timeRemaining, textStyle);
		}
		else{
			timer.text = "Time's Up!";

			//GUI.Label(new Rect(600, 100, 200, 100), "Time's Up");
		}
	}

	public void goToMenu(){
		Application.LoadLevel (1);
	}
}