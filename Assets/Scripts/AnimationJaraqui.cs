using UnityEngine;
using System.Collections;

public class AnimationJaraqui : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
	}
	//void OnLevelWasLoaded (){
	//	anim.SetTrigger ("start");
	//	anim.ResetTrigger ("dizzy");
	//	anim.ResetTrigger ("shock");
	//}
	void Update () {
		if (Controller.animctrl == 0){
			anim.SetTrigger ("start");
		}
		if (Controller.animctrl == 1) {
			anim.SetTrigger ("shock");
		}
		if (Controller.animctrl == 2) {
			anim.SetTrigger ("dizzy");
		}
	}
}
