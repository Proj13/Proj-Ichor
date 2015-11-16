using UnityEngine;
using System.Collections;

public class victimCount : MonoBehaviour {

	public GUIText countText;
	private int count;

	void Start () {
		count = GameObject.FindGameObjectsWithTag ("Victim").Length;
		updateCount ();
	}
	
	public void subtractCount (int newCountValue) {
		count -= newCountValue;
		if (count < 0) {
			count = 0;
		}
		updateCount ();
	}

	void updateCount(){
		countText.text = "Victims Needed: " + count;
	}
}
