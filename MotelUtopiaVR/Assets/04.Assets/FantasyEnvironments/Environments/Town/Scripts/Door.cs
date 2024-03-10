using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter (Collider other) {
		anim.SetBool ("DoorOpen", true);

	}

	void OnTriggerExit (Collider other) {
		anim.SetBool ("DoorOpen", false);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
