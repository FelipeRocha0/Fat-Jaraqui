using UnityEngine;
using System.Collections;

public class Ancora : MonoBehaviour {
	public Vector2 speed;
	public Vector2 fallSpd;
	private GameObject Cparent;
	float posicao = -1f;
	void Start () {
		GetComponent<Rigidbody2D>().velocity = speed;
		Cparent = GameObject.Find ("Canvas");
		transform.parent = Cparent.transform;
		transform.SetAsFirstSibling ();
		Invoke ("Colisor", 2f);
		
	}

	void Colisor (){
				GetComponent<Collider2D>().isTrigger = false;
		}
	void Update () {
				transform.position = new Vector3 (transform.position.x, transform.position.y, posicao);
				if (transform.position.x < -25f) {
						GameObject.Destroy (this.gameObject);
						//Debug.Log ("=/");
				}
		//if (transform.position.y > 8) {
		//	rigidbody2D.velocity = speed2;
		//} else if (transform.position.y < 0){
		//	rigidbody2D.velocity = speed;
		//}
		}
	//void Revert () {
	//	if (transform.position.y > 6) {
	//		rigidbody2D.velocity = speed2;
	//	} else if (transform.position.y < -6){
	//		rigidbody2D.velocity = speed2;
	//	}
	//}

}