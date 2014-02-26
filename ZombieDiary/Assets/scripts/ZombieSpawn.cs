using UnityEngine;
using System;
using System.Collections;


public class ZombieSpawn : MonoBehaviour {

	public GameObject prefab;
	public GameObject spawn_position1;
	public GameObject spawn_position2;
	public GameObject spawn_position3;
	public GameObject spawn_position4;
	private GameObject[] spawn = new GameObject[4];
	public int x = 0; 
	public int y = 0;
	//private bool is_spawn = true;
	float last_spawn = 0;
	// Use this for initialization
	void Start () {
		spawn [0] = spawn_position1;
		spawn [1] = spawn_position2;
		spawn [2] = spawn_position3;
		spawn [3] = spawn_position4;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > last_spawn)
		{
			float rnd_number_of_zombies = UnityEngine.Random.Range (1, 4.99f);
			Debug.Log ("number" + rnd_number_of_zombies);
			last_spawn += 1;
			int[] emty_spawn = new int[4];
			Array.Clear(emty_spawn, 0, 3);
			for (int i = 0; i < (int) rnd_number_of_zombies; i++)
			{
				float rnd_pos = UnityEngine.Random.Range (0, 4);
				Debug.Log ("pos" + (int) rnd_pos);
				if (emty_spawn[(int) rnd_pos] != 0)
				{
					for (int k = 0; k < 4; k++)
					{
						if (emty_spawn[k] == 0)
						{
							rnd_pos = k;
						}
					}
				}

				Debug.Log("after check");
				Vector3 pos = spawn[(int) rnd_pos].transform.position;
				Instantiate (prefab, pos, Quaternion.identity);
				emty_spawn[(int) rnd_pos] = 1;
			}
		}
	}
}
