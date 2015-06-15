using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {
	
	void Awake () {
		InvokeRepeating ("flicker", 0.5f, 0.5f);
	}
	void flicker () {
				if (gameObject.activeSelf == true)
						gameObject.SetActive (false);
				else
						gameObject.SetActive (true);
		}

}
