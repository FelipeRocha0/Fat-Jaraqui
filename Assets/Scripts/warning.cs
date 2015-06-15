using UnityEngine;
using System.Collections;

public class warning : MonoBehaviour {

	// Use this for initialization
	void Awake ()
    {
        Invoke("desativar", 4f);
	}
	
	// Update is called once per frame
	void desativar ()
    {
        gameObject.SetActive(false);
    }
}
