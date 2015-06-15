using UnityEngine;
using System.Collections;

public class BgOffSet : MonoBehaviour {
	public float speed;
	float pos = 0;

	void Update () {
		pos += speed*Time.deltaTime;
		if (pos > 1.0f) 
			pos -= 0;
		GetComponent<Renderer>().material.mainTextureOffset = (new Vector2 (pos, 0));
	}
}
