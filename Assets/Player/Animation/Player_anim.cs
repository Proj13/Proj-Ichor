using UnityEngine;
using System.Collections;

public class Player_anim : MonoBehaviour 
{
	Animator anim;
	int jumpHash = Animator.StringToHash("Jump");
	int walkLHash = Animator.StringToHash("WalkLeft");
	int walkRHash = Animator.StringToHash("WalkRight");
	int stabHash = Animator.StringToHash ("Stab");
	int hideHash = Animator.StringToHash ("Hide");
	bool facingRight = false;

	
	
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	
	void Update ()
	{

		if(Input.GetKeyDown (KeyCode.E)){
			anim.SetBool (stabHash, true);

		}
		if(Input.GetKeyUp (KeyCode.E)){
			anim.SetBool (stabHash, false);
			
		}



		if(Input.GetKeyDown (KeyCode.LeftShift)){
			anim.SetBool (hideHash, true);
			
		}
		if(Input.GetKeyUp (KeyCode.LeftShift)){
			anim.SetBool (hideHash, false);
			
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool (jumpHash, true);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetBool (jumpHash, false);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool (walkRHash, true);
			if(facingRight == false){
				Flip();
			}

		}
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetBool (walkLHash, true);
			if(facingRight == true){
				Flip();
			}

		}
		if (Input.GetKeyUp (KeyCode.A)) {
			anim.SetBool (walkLHash, false);

		}
		if (Input.GetKeyUp (KeyCode.D)) {
			anim.SetBool (walkRHash, false);

		}
	}

	void Flip()
	{
		// Switch the way the player is labelled as facing
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


}