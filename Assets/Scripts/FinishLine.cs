﻿using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {
	
	public int count;




	void Update(){
		count = updateCount (count);

		
	}
	
	
	
	int updateCount(int count){
		count = GameObject.FindGameObjectsWithTag ("Victim").Length;

		return count;
	}

	void OnTriggerEnter2D (Collider2D col){
		
		Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);


		if (count == 0) {
			Debug.Log(	"Player has won the game");
			Application.LoadLevel("startScreenMenu");

		}
		else 
			Debug.Log("Find more victims");



		
	}



}