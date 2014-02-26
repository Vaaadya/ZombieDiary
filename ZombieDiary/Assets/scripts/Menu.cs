using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	// Use this for initialization
	public GameObject gamePanel;
	public GameObject gameButtons;
	void Start () {
		gamePanel.SetActive(false);
	}
	// Update is called once per frame
	void OnGUI () {
		int btnWidth = Screen.width - Screen.width/10;
		int btnHeight = Screen.height/5;
		int dist = Screen.height/6 - Screen.height/10;
		bool btnStart = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, dist, btnWidth, btnHeight), "Start");
		GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 3*dist + btnHeight, btnWidth, btnHeight), "Options");
		GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 5*dist + 2*btnHeight, btnWidth, btnHeight), "Exit");
		if(btnStart)
		{
			this.gameObject.SetActive(false);
			gameButtons.SetActive(true);
			gamePanel.SetActive(true);
			Time.timeScale = 1;
		}
	}
}
