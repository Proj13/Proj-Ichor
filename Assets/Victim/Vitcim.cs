using UnityEngine;
using System.Collections;

public class Vitcim : MonoBehaviour {

	Animator anim;
	int dead = Animator.StringToHash("dead");








	void Start ()
	{
		anim = GetComponent<Animator>();

		
	}



	IEnumerator OnTriggerEnter2D (Collider2D col){

			Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);
			anim.SetBool (dead, true);
			yield return new WaitForSeconds(1);
			Destroy (this.gameObject);

	}








}
