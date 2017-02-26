using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	// speedを制御する
	public float speed = 10;

	void Update ()
	{
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// xとyにspeedを掛ける
		rigidbody.AddForce(inputX * speed, 0, inputZ * speed);
	}
}