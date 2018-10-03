using System.Collections;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("joystick 1 button 0"))
	
			anim.Play("Bend");

		{
			if (Input.GetAxis("Horizontal") > 0)

				anim.Play("Walk");
				{
					if (Input.GetAxis("Vertical") > 0)
					
						anim.Play("Walk");
			}
					if (Input.GetKeyDown("joystick 1 button 1")) 
			
				anim.Play("Place");
			}
}
}
					
	
