using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemy : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;
	Animator anim;
	int dead = Animator.StringToHash("kill");
	//GameObject spawn = GameObject.Find("Spawn");
	public GameObject backgroundAudio;

	public Canvas gameOver;
	public Button exitToMenu;
	
	
	
	
	
	
	void Start ()
	{
		anim = GetComponent<Animator>();
		audio = GetComponent<AudioSource>();
		backgroundAudio = GameObject.Find("Slash Theme 2");
		gameOver = gameOver.GetComponent<Canvas> ();
		exitToMenu = exitToMenu.GetComponent<Button> ();


		
	}
	
	
	//EDIT HERE FOR POLICE KILL TRIGGER
	IEnumerator OnTriggerEnter2D (Collider2D col){
		
		Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);
		anim.SetBool (dead, true);
		backgroundAudio.GetComponent<AudioSource> ().Stop ();
		audio.PlayOneShot(impact, 0.7F);
		gameOver.enabled = true;
		exitToMenu.enabled = true;

		yield return new WaitForSeconds(5);



		Application.LoadLevel (Application.loadedLevel);
		//col.gameObject.SetActive (false);

		
	}
	
	

}
