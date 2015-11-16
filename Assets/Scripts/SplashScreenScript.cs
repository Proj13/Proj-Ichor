using UnityEngine;
using System.Collections;

public class SplashScreenScript : MonoBehaviour {
	public float timer = 2f;
	//public string levelToLoad = "Main Menu";

	// Use this for initialization
	void Start () {
		StartCoroutine("DisplayScene");
	}
	
	IEnumerator DisplayScene() {
		yield return new WaitForSeconds (timer);
		//use following code for fade transitions
		float fadeTime = GameObject.Find ("ScreenFader").GetComponent<FadingScript> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel (Application.loadedLevel+1);

	}

	void Update(){
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel (Application.loadedLevel+1);
		}
	}
}
