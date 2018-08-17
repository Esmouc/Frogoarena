using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogoMovement : MonoBehaviour {

	public int speed;

	private bool praying = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!praying) {

			GetComponent<Animator> ().SetBool ("IsMoving", false);

			if (Input.GetKey(KeyCode.W)) {
				GetComponent<Animator> ().SetBool ("IsMoving", true);
				transform.position += Vector3.forward * speed * Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.A)) {
				GetComponent<Animator> ().SetBool ("IsMoving", true);
				transform.position += -Vector3.right * speed * Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.D)) {
				GetComponent<Animator> ().SetBool ("IsMoving", true);
				transform.position += Vector3.right * speed * Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.S)) {
				GetComponent<Animator> ().SetBool ("IsMoving", true);
				transform.position += -Vector3.forward * speed * Time.deltaTime;
			}

		}

		if (Input.GetMouseButton(1)) {
			praying = true;
			GetComponent<Animator> ().SetBool ("IsPraying", true);
		} else {
			praying = false;
			GetComponent<Animator> ().SetBool ("IsPraying", false);
		} 
		
	}
}
