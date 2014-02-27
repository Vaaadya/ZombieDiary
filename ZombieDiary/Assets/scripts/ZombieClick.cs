using UnityEngine;
using System.Collections;

public class ZombieClick : MonoBehaviour {

	public Camera cam;
	private float next_time_shoot = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && Time.time > next_time_shoot)
		{
			next_time_shoot = Time.time + 0.1f;
			RaycastHit2D obj = Physics2D.Raycast(new Vector2(cam.ScreenToWorldPoint(Input.mousePosition).x,
			                                    cam.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0f);

				obj.transform.SendMessage("IsShooted", SendMessageOptions.DontRequireReceiver);

		}
	}
}
