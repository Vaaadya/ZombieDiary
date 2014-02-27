using UnityEngine;
using System.Collections;

public class ToPauseMenu : MonoBehaviour {

	public GameObject gamePanel;
	public GameObject gameButtons;
	public GameObject mainMenu;
	void Start () {
		gamePanel.SetActive(false);
	}
	// Update is called once per frame
	void OnGUI () {
		int btnWidth = Screen.width - Screen.width/10;
		int btnHeight = Screen.height/6;
		int dist = Screen.height/8 - Screen.height/12;
		bool btnResume = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, dist, btnWidth, btnHeight), "Resume");
		GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 3*dist + btnHeight, btnWidth, btnHeight), "Options");
		bool btnMain = GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 5*dist + 2*btnHeight, btnWidth, btnHeight), "Main menu");
		GUI.Button(new Rect(Screen.width/2 - btnWidth/2, 7*dist + 3*btnHeight, btnWidth, btnHeight), "Exit");
		if(btnResume)
		{
			this.gameObject.SetActive(false);
			gameButtons.SetActive(true);
			gamePanel.SetActive(true);
			Time.timeScale = 1;
		}
		if (btnMain)
		{
			this.gameObject.SetActive(false);
			gamePanel.SetActive(false);
			mainMenu.gameObject.SetActive(true);
		}
	}
}
