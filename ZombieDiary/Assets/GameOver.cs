using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	private bool win = true;
	public GameObject game_panel;
	public GameObject main_menu;
	// Use this for initialization
	void OnEnable()
	{
		GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
		for (int i = 0; i < zombies.Length; i++)
		{
			Destroy(zombies[i].gameObject);
		}
		game_panel.SetActive (false);
	}
	// Update is called once per frame
	void OnGUI () {
		int btnWidth = Screen.width - Screen.width/10;
		int btnHeight = Screen.height/5;
		int dist = Screen.height/4 - Screen.height/8;
		if (win) 
		{
			GUI.Label (new Rect (10, 10, 50, 50), "WIN");
			bool btn_next_level = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, dist, btnWidth, btnHeight), "Next Game");
			bool btn_main = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 3*dist + btnHeight, btnWidth, btnHeight), "Main menu");
			if(btn_next_level)
			{
				this.gameObject.SetActive(false);
				game_panel.SetActive(true);
			}
			if (btn_main)
			{
				this.gameObject.SetActive(false);
				main_menu.gameObject.SetActive(true);
			}
		}
		else 
		{
			GUI.Label (new Rect (10, 10, 50, 50), "LOSE");
			GUI.Label (new Rect (10, 10, 50, 50), "WIN");
			bool btn_next_level = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, dist, btnWidth, btnHeight), "Retry");
			bool btn_main = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 3*dist + btnHeight, btnWidth, btnHeight), "Main menu");
			if(btn_next_level)
			{
				this.gameObject.SetActive(false);
				game_panel.SetActive(true);
			}
			if (btn_main)
			{
				this.gameObject.SetActive(false);
				main_menu.gameObject.SetActive(true);
			}
		}
	}
	void SetResult (bool result)
	{
		win = result;
	}
}
