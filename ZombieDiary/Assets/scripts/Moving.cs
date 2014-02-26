using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("W"))
		{
			this.rigidbody2D.transform.Translate (Vector2.up);
		}
	}
}
