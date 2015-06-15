using UnityEngine;
using System.Collections;

public class MinhocaBehavior : MonoBehaviour {
	public Vector2 speed;
	private GameObject Cparent;
	float posicao = -1f;
	void Start ()
    {
		GetComponent<Rigidbody2D> ().velocity = speed;
		Cparent = GameObject.Find ("Canvas");
		transform.parent = Cparent.transform;
		transform.SetAsFirstSibling ();	
	}
	
	// Update is called once per frame
	void Update ()
    {
		transform.position = new Vector3 (transform.position.x, transform.position.y, posicao);
        if (transform.position.x < -30f)
            Destroy(this.gameObject); 
	}
}