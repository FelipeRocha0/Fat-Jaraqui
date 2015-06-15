using UnityEngine;
using System.Collections;

public class oneup : MonoBehaviour {
    private GameObject Cparent;
    void Start ()
    {
        Invoke("destruir", 5f);
	}
    void Update()
    {
        Cparent = GameObject.Find("Canvas");
        transform.parent = Cparent.transform;
        transform.SetAsFirstSibling();
    }
	
	// Update is called once per frame
	void destruir ()
    {
        Destroy(this.gameObject);
	}
}
