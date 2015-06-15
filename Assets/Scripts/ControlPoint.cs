using UnityEngine;
using System.Collections;

public class ControlPoint : MonoBehaviour {
	private string lvl;
	void Awake () {
		//Mantem a tela acordada
		Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
		//objeto permanece em todas as cenas
		DontDestroyOnLoad (this.gameObject);
	
	}
	void OnLevelWasLoaded (){
		lvl = Application.loadedLevelName;
		if (lvl == "Game Over") {
				} else {
						Score.score = 0;
						Time.timeScale = 1f;
						Menu.isPaused = false;
				}
		}
}
