using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOverScript : MonoBehaviour {
	
	float timeRemaining;
	public Canvas gameOver;
	public Button exitToMenu;
	public TimeScript timescript;
	//public float savedTimeScale;
	
	void Start(){
		gameOver = gameOver.GetComponent<Canvas> ();
		exitToMenu = exitToMenu.GetComponent<Button> ();
		gameOver.enabled = false;
	}
	void Update () {
		timeRemaining = timescript.timeLimit;
		if(timeRemaining < 0){
			gameOver.enabled = true;
			exitToMenu.enabled = true;
			//savedTimeScale = Time.timeScale;
			//Time.timeScale = 0.0f;
		}
	}
	
	public void goToMenu(){
		//Time.timeScale = savedTimeScale;
		Application.LoadLevel ("startScreenMenu");
	}
}