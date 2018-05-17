using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour {

	// Use this for initialization
	public Rigidbody rb; 
	public float fforce = 2000f;
	public float sforce = 500f;
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (0, 0, fforce * Time.deltaTime);
		if (Input.GetKey ("d")) 
		{
			rb.AddForce (sforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-sforce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
		}
	}
}
