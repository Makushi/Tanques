using UnityEngine;

public class Fire : MonoBehaviour {

	public float speed;

	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.AddRelativeForce (Vector3.up * speed, ForceMode.Impulse);

		Destroy (gameObject, 2.0f);
	}

	void OnCollisionEnter(Collision col) 
	{
		if (col.gameObject.name == "Panzer") 
		{
			print ("Cabio player 1");
		}

		if (col.gameObject.name == "Panzer 2") 
		{
			print ("Cabio player 2");
		}
	}

}
