using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	private Rigidbody tank;
	public KeyCode MoveForward;
	public KeyCode MoveBackwards;
	public KeyCode SteerLeft;
	public KeyCode SteerRight;
	// Use this for initialization
	void Start () {
		tank = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (MoveForward)) 
		{
			transform.Translate (Vector3.forward * Time.deltaTime * 25);
		}
		if (Input.GetKey (MoveBackwards)) 
		{
			transform.Translate (Vector3.back * Time.deltaTime * 25);
		}
		if (Input.GetKey (SteerLeft)) 
		{
			transform.Rotate (Vector3.down * Time.deltaTime * 50);
		}
		if (Input.GetKey (SteerRight)) 
		{
			transform.Rotate (Vector3.up * Time.deltaTime * 50);
		}
	}
}
