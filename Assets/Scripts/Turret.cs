using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	private Rigidbody tank;
	public GameObject prefab;
	public Transform flash;
	public KeyCode RotateTurretLeft;
	public KeyCode RotateTurretRight;
	public KeyCode Fire;
	// Use this for initialization
	void Start () {
		tank = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (RotateTurretLeft)) 
		{
			transform.Rotate (Vector3.down * Time.deltaTime * 100);
		}

		if (Input.GetKey (RotateTurretRight)) 
		{
			transform.Rotate (Vector3.up * Time.deltaTime * 100);
		}

		if (Input.GetKeyDown (Fire)) 
		{
			Quaternion dasdasd = Quaternion.Euler(flash.eulerAngles + Vector3.left * 90);
			Instantiate (prefab, flash.position, dasdasd);
		}
	}
}
