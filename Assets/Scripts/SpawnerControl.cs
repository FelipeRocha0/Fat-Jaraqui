using UnityEngine;
using System.Collections;

public class SpawnerControl : MonoBehaviour {
	GameObject powerup;
	GameObject normal;
	GameObject alerta;

	int puraqueSom;
	public string NomeDoObjeto;

	AudioSource som;
	void Awake () {
		som = GetComponent<AudioSource> ();
		puraqueSom = GameObject.FindGameObjectsWithTag (NomeDoObjeto).Length;
		powerup = GameObject.Find ("SpawnerPowerUps");
		normal = GameObject.Find ("spawnerNormal");
		alerta = GameObject.Find ("spawnerAlerta");
		}
	// Update is called once per frame
	void Update () {
	if (puraqueSom > 0)
						som.volume = 0.7f;
				else
						som.volume = 0f;
    if (Controller.StopSpawn == true)
        {
            powerup.SetActive(false);
            normal.SetActive(false);
            alerta.SetActive(false);
        }
	else if (Controller.alert == false)
    {
		powerup.SetActive(true);
		normal.SetActive(true);
		alerta.SetActive(false);
    }
	else if (Controller.alert == true)
    {
		powerup.SetActive(false);
		normal.SetActive(false);
		alerta.SetActive(true);
	}
	}
}
