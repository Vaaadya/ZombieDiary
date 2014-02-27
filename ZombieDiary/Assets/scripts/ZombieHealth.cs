using UnityEngine;
using System.Collections;

public class ZombieHealth : MonoBehaviour {
	public GameObject object_after_death;
	private int health = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
		{
			Dead();
			Instantiate(object_after_death, this.transform.position, Quaternion.identity);
		}
	}

	void IsShooted()
	{
		health -= 1;
	}

	void Dead()
	{
		Destroy (this.gameObject);
	}
}
