using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameWinScript : MonoBehaviour {
	
	float timeRemaining;
	public Canvas gameWin;
	public Button exitToMenu;
	public victimCount countObject;
	int count;	
	//public float savedTimeScale;
	
	void Start(){
		gameWin = gameWin.GetComponent<Canvas> ();
		exitToMenu = exitToMenu.GetComponent<Button> ();
		gameWin.enabled = false;
		count = GameObject.FindGameObjectsWithTag ("Victim").Length;
	}
	void Update () {
		count = GameObject.FindGameObjectsWithTag ("Victim").Length;
		if(count == 0){
			gameWin.enabled = true;
			exitToMenu.enabled = true;
			//savedTimeScale = Time.timeScale;
			//Time.timeScale = 0.0f;
		}
	}
	
	public void goToMenu(){
		//Time.timeScale = savedTimeScale;
		Application.LoadLevel (1);
	}
}