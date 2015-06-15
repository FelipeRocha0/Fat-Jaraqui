using UnityEngine;
using System.Collections;

public class Jukebox : MonoBehaviour {
	public static int faixa = 1;
	private int value = 1;

	protected AudioSource som;

	public static bool pausa;

	public AudioClip faixa1;
	public AudioClip faixa2;
	public AudioClip faixa3;
	public AudioClip faixa4;
	void Awake () {
		som = GetComponent<AudioSource> ();
		som.Play ();
	}
	void Update () {
//				if (faixa != value)
//						Invoke ("troca", 0.5f);
				if (Menu.isPaused == true) som.volume = 0.3f;
				else som.volume = 0.8f;
		}
	void troca (){
			if (faixa == 1){
				som.PlayOneShot (faixa1);
				value = 1;}
			if (faixa == 2){
				som.PlayOneShot (faixa2);
				value = 2;}
			if (faixa == 3){
				som.PlayOneShot (faixa3);
				value = 3;}
			if (faixa == 4){
				som.PlayOneShot (faixa4);
				value = 4;}
		}
}
