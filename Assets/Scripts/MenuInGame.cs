using UnityEngine;
using System.Collections;

public class MenuInGame : MonoBehaviour {
	protected static GameObject objct;
	protected static GameObject objct2;
	void Start () {
		objct = (GameObject.Find("Pausa"));
		objct2 = (GameObject.Find("UI"));
		if (gameObject.name == "Pausa") {
			gameObject.SetActive (false);
		} else {
			gameObject.SetActive (true);
		}
	}
	public static void Toggle () {
		if (Menu.isPaused == false)
		{
			objct.SetActive(false);
			objct2.SetActive(true);
		}
		else
		{
			objct.SetActive(true);
			objct2.SetActive(false);
		}
	}
}

