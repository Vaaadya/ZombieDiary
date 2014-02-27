using UnityEngine;
using System.Collections;

public class Smile : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
			anim.SetFloat ("Velo", this.rigidbody2D.velocity.y);
	}
}
