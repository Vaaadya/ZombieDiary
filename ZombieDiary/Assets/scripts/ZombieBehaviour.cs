using UnityEngine;
using System.Collections;

public class ZombieBehaviour : MonoBehaviour {
	public float zobbie_speed = 2;
	public float min_distance = 0.5f;
	private GameObject castle;
	// Use this for initialization
	void Start () {
		castle = GameObject.FindWithTag ("Castle");
	}

	// Update is called once per frame
	void Update () 
	{
		Vector2 dir = new Vector2 (castle.rigidbody2D.transform.position.x - rigidbody2D.transform.position.x,
		                       castle.rigidbody2D.transform.position.y - rigidbody2D.transform.position.y);
		if (Mathf.Abs (dir.y) > min_distance) 
		{
			rigidbody2D.velocity = dir.normalized * zobbie_speed;
		}
			else
		{
			rigidbody2D.velocity = new Vector2(0, 0);
		}

	}
}
