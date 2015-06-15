using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public static int score = 0;
	public int highScore = 0;
	string highScoreKey = "highScore";

	protected Text text;
	void Start () 
	{
		highScore = PlayerPrefs.GetInt(highScoreKey,0);
		text = GetComponent <Text> ();
	}
	void Update () {
				if (gameObject.name == "Recordetxt") {
						text.text = "" + highScore;
				} else if (gameObject.name == "Recordet") {
						text.text = "Recorde: " + highScore;
				} else {
						text.text = "" + score;
				}
		}
	void OnDisable(){
		if(score>highScore){
			PlayerPrefs.SetInt(highScoreKey, score);
			PlayerPrefs.Save();
		}
}
}