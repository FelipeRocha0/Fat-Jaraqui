using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public static bool confirm = false;
	public static bool isPaused = false;
	private string level;

	private GameObject sw;
	//protected GameObject confirm;
	void Awake () {
				level = Application.loadedLevelName;
				if (level == "Jogo") {
						//confirm = GameObject.Find ("Confirm");
						sw = GameObject.Find("Swit");
				}
				if (level == "Menu") {
						//confirm = GameObject.Find ("Confirm");
				}
		}
	public void PlayClick (){
		Application.LoadLevel ("Jogo");
		Time.timeScale = 1f;
		isPaused = false;
	}
	public void MenuClick (){
		Application.LoadLevel ("Menu");
	}
	public void InfoClick (){
		Application.LoadLevel ("Info");
	}
	public void CredClick (){
		Application.LoadLevel ("Creditos");
	}
	public void PauseClick (){
				if (isPaused == false) {
						Time.timeScale = 0f;
						isPaused = true;
						MenuInGame.Toggle();
				} else {
						Time.timeScale = 1f;
						isPaused = false;
						MenuInGame.Toggle();
				}
	}
	public void ConfirmClick (){
		confirm = true;
		confirmbutton.Toggle ();
	}
	public void CancelClick (){
		confirm = false;
		confirmbutton.Toggle ();
	}
	public void AudioClick (){
	//adicionar controles de audio.
		if (GameObject.FindGameObjectWithTag ("Switch").activeSelf == true)				
		GameObject.FindGameObjectWithTag ("Switch").SetActive (false);
		if (GameObject.FindGameObjectWithTag ("Switch").activeSelf == false)
		GameObject.FindGameObjectWithTag ("Switch").SetActive (true);
	}
	public void ExitClick (){
				Application.Quit ();
		}
	public void RateClick (){
				//adicionar url do google play
		}
	void Update () {
		level = Application.loadedLevelName;
		if (Input.GetKeyDown(KeyCode.Escape)){
			if (level == "Jogo"){
				if (Time.timeScale == 1f){
					Invoke ("PauseClick", 1f);
				} else {
					Invoke ("ConfirmClick", 1f);
				}
			}
			if (level == "Menu"){
				Invoke ("ConfirmClick", 1f);
			}
			if (level == "Creditos"){
				Application.LoadLevel ("Info");
			} else {
				Application.LoadLevel ("Menu");
			}
		}
	}
}