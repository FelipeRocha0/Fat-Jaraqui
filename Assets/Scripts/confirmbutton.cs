using UnityEngine;
using System.Collections;

public class confirmbutton : MonoBehaviour {
	protected static GameObject objct;
	void Start () {
		objct = (GameObject.Find("Confirm"));
		if (gameObject.name == "Confirm") {
			gameObject.SetActive (false);
		} else {
			gameObject.SetActive (true);
		}
	}
	public static void Toggle () {
		if (Menu.confirm == false)
		{
			objct.SetActive(false);
		}
		else
		{
			objct.SetActive(true);
		}
	}
}