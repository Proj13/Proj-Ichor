using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOverScript : MonoBehaviour {
	
	float timeRemaining = 60.0f;
	public Canvas gameOver;
	public Button exitToMenu;
	//public float savedTimeScale;
	
	void Start(){
		gameOver = gameOver.GetComponent<Canvas> ();
		exitToMenu = exitToMenu.GetComponent<Button> ();
		gameOver.enabled = false;
	}
	void Update () {
		timeRemaining -= Time.deltaTime;
		if(timeRemaining < 0){
			gameOver.enabled = true;
			exitToMenu.enabled = true;
			//savedTimeScale = Time.timeScale;
			Time.timeScale = 0.0f;
		}
	}
	
	public void goToMenu(){
		//Time.timeScale = savedTimeScale;
		Application.LoadLevel ("startScreenMenu");
	}
}