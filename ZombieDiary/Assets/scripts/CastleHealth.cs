using UnityEngine;
using System.Collections;

public class CastleHealth : MonoBehaviour {
	private bool is_base_dead = false;
	private bool is_time_ended = false;
	public GameObject game_over_menu;
	private int heath = 10;
	private float round_time = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time > round_time && heath > 0 && is_time_ended == false)
		{
			SetWin();
			is_time_ended = true;
		}
		if (heath <= 0 && is_base_dead == false)
		{
			SetLose();
			is_base_dead = true;
		}
	}

	void EatBase()
	{
		heath -= 1;
	}
	void SetWin()
	{
		game_over_menu.SetActive (true);
		game_over_menu.SendMessage ("SetResult", true);
	}
	void SetLose()
	{
		game_over_menu.SetActive (true);
		game_over_menu.SendMessage ("SetResult", false);
	}
}
