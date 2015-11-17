using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	
	Animator anim;
	int dead = Animator.StringToHash("kill");
	//GameObject spawn = GameObject.Find("Spawn");	
	
	
	
	
	
	
	void Start ()
	{
		anim = GetComponent<Animator>();
		
		
	}
	
	
	//EDIT HERE FOR POLICE KILL TRIGGER
	IEnumerator OnTriggerEnter2D (Collider2D col){
		
		Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);
		anim.SetBool (dead, true);
		yield return new WaitForSeconds(1);
		Application.LoadLevel (Application.loadedLevel);
		//col.gameObject.SetActive (false);

		
	}
	
	

}
