using UnityEngine;
using System.Collections;

public class ToMainMenu : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject gamePanel;
	public GameObject pauseMenu;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void OnGUI () {
		int btnWidth = Screen.width/4;
		int btnHeight = Screen.height/10;
		bool btnPause = GUI.Button(new Rect(btnHeight/3, Screen.height - btnHeight - btnHeight/3, btnWidth, btnHeight), "Pause");
		bool btnToMenu = GUI.Button(new Rect(Screen.width - btnWidth - btnHeight/3, Screen.height - btnHeight - btnHeight/3, btnWidth, btnHeight), "Menu");
		if (btnToMenu)
		{
			gamePanel.SetActive(false);
			mainMenu.SetActive(true);
		}
		if(btnPause)
		{
			pauseMenu.SetActive(true);
			this.gameObject.SetActive(false);
			Time.timeScale = 0;
		}
	}
}
