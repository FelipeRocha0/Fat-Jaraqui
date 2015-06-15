using UnityEngine;
using System.Collections.Generic;

public class Generate : MonoBehaviour{
	public float maxWidth;
	public float minWidth;
	
	public float rateSpawn;
	
	private float currentRateSpawn;
	
	public int maxObject;
	
	public GameObject objeto;

	public bool ObjetoDeAlerta;

    public int maxSpawned;

	public string NomeDoObjeto;
	private Collider2D checkResult;

	void Update ()
    {
        maxSpawned = GameObject.FindGameObjectsWithTag(NomeDoObjeto).Length;
        currentRateSpawn += Time.deltaTime;
		if (currentRateSpawn > rateSpawn) {
			currentRateSpawn = 0;
			Spawn ();
		}
	}
	void Spawn ()
    {
		float randPosition = Random.Range (minWidth, maxWidth);
		if (ObjetoDeAlerta == false) checkResult = Physics2D.OverlapCircle((new Vector2 (transform.position.x, randPosition)), 2);
		else checkResult = Physics2D.OverlapCircle((new Vector2 (randPosition, transform.position.y)), 2);
		if (checkResult == null)
        {
		    if (maxSpawned < maxObject)
            {
				Instantiate (objeto);
				if (ObjetoDeAlerta == false) objeto.transform.position = new Vector2 (transform.position.x, randPosition);
				else objeto.transform.position = new Vector2 (randPosition, transform.position.y);
		    }
		}
	}	
}