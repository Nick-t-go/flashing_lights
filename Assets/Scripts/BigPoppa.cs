using UnityEngine;
using System.Collections;

public class BigPoppa : MonoBehaviour {
	public KeyCode Space;
	public string Maybe;

	void Update()
	{
		if (Input.GetKey ("space"))
			GetComponent<Animator> ().SetTrigger ("Idle");
		print ("space key was pressed");

		if (Input.GetKey ("joystick 1 button 0"))
			GetComponent<Animator> ().SetTrigger ("Place");
		if (Input.GetKey("joystick 1 button 1"))
			GetComponent<Animator>().SetTrigger ("Walk");
		if (Input.GetKey ("joystick 1 button 3"))
			GetComponent<Animator> ().SetBool ("Bend", true);

		print("xbox key pressed!");


	

	}
}