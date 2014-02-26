using UnityEngine;
using System.Collections;

public class ToMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		int btnWidth = Screen.width/4;
		int btnHeight = Screen.height/10;
		bool btnToMenu = GUI.Button(new Rect(Screen.width - Screen.width/20, Screen.width/20, btnWidth, btnHeight), "Start");
	}
}
