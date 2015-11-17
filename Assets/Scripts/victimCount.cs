using UnityEngine;
using System.Collections;

public class victimCount : MonoBehaviour {

	public GUIText countText;
	public int count;



	void Update(){
		count = updateCount (count);

	}
	


	int updateCount(int count){
		count = GameObject.FindGameObjectsWithTag ("Victim").Length;
		countText.text = "Victims Needed: " + count;
		return count;
	}
}
