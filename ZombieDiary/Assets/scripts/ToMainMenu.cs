using UnityEngine;
using System.Collections;

public class ToMainMenu : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject gamePanel;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void OnGUI () {
		int btnWidth = Screen.width/4;
		int btnHeight = Screen.height/10;
		bool btnToMenu = GUI.Button(new Rect(Screen.width/20, Screen.height - btnHeight - btnHeight/3, btnWidth, btnHeight), "Menu");
		if (btnToMenu)
		{
			gamePanel.SetActive(false);
			mainMenu.SetActive(true);
		}
	}
}
