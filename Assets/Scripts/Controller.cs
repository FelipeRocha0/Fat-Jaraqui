using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public Vector2 forca;
	public Vector2 Pushback;
	public Vector2 pushck;

	private float posx;
	private Vector2 touchinput;

	private bool powerup;

	public static bool StopSpawn = false;
	public static bool alert = false;
	//public static bool alerttimer = false;
	private bool shock = false;
	private bool smash = false;
	private bool cmmds = false;

	public AudioClip choque;
	public AudioClip baque;

	protected AudioSource sfx;

	private GameObject Tutorial;
    private GameObject Tutorial2;
    public GameObject oneup;

    public static int animctrl = 0;

    void OnLevelWasLoaded (int level)
    {
		if (level == 1) {
						cmmds = false;
						//alerttimer = false;
						StopSpawn = false;
						alert = false;
						shock = false;
						smash = false;
				}
	}
	void Awake()
    {
		sfx = GetComponent<AudioSource> ();
		Score.score = 0;
		animctrl = 0;
		Tutorial = GameObject.Find ("TutorialAlerta");
        Tutorial2 = GameObject.Find("TutorialAlerta2");
        Tutorial.SetActive (false);
		posx = transform.position.x;
		InvokeRepeating ("sps", 1f, 1f);
		Invoke ("preparation", 10f);			
	}

    //Para o Spawn de puraques e invoca o Overlay
    void preparation()
    {
        Invoke("callAlert", 8f);
        StopSpawn = true;
    }
    
    //Chama o Overlay de alerta
	void callAlert()
    {
		Tutorial.SetActive (true);
        cmmds = true;
    }

    //Estado de alerta, chamado dentro dos tutoriais de alerta
    public void alerta()
    {
        StopSpawn = false;
        alert = true;
        Invoke("preparation2", 15f);
    }

    //Para o spawn de ancoras e Chama o segundo Overlay
    void preparation2()
    {
        StopSpawn = true;
        Invoke("stopAlert", 15f);
    }
	void stopAlert()
    {
        Tutorial2.SetActive(true);
	}
    public void Retornar()
    {
        cmmds = false;
        alert = false;
        Invoke("preparation", 25f);
    }
    //1 ponto por segundo de jogo
	void sps (){Score.score++;}
    //Efeitos de colisão com inimigos e powerups
	void OnTriggerEnter2D(Collider2D collider){
		if (!powerup)
		switch (collider.gameObject.name) {
		case "p(Clone)":
			if (StopSpawn == false)
			animctrl = 1;
			if (StopSpawn == false)
			shock = true;
			sfx.PlayOneShot (choque);
				break;
		case "ancora":
			smash = true;
			animctrl = 2;
			sfx.PlayOneShot (baque);
				break;
		case "Minhoca(Clone)":
            Destroy(collider.gameObject);
            Score.score++;
            Instantiate(oneup);
            oneup.transform.position = new Vector2(transform.position.x, transform.position.y);
			break;
		case "Estrela(Clone)":
//			AudioCtrl.ctrl = 3;
//			AudioCtrl.Jukebox ();
			Invoke ("disablePU", 10f);
			break;
		}
		else
		switch (collider.gameObject.name) {
		case "Estrela(Clone)":
			Invoke ("disablePU", 10f);
			break;
		case "Minhoca(Clone)":
			Score.score++;
			break;
		}
	}
	void disablePU () {
				powerup = false;
		}
	void shockBehavior (){

				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		}
	void shockP2 (){
		GetComponent<Rigidbody2D> ().velocity = -forca / 4;
		}
	void Update ()
    {
		GetComponent<Rigidbody2D>().velocity *= 0.98f;
		touchinput = (new Vector2 (Input.acceleration.x*Time.deltaTime, 0));
        if (transform.position.y < -7) Application.LoadLevel("Game Over");
        if (shock == true)
        {
			InvokeRepeating ("shockBehavior", 1f, 1f);
			InvokeRepeating ("shockP2", 0.5f, 1f);
		} else if (smash == true) GetComponent<Rigidbody2D>().AddForce (-forca/3);
		else
        {
			if (cmmds == true)
            {
				GetComponent<Rigidbody2D>().AddForce (touchinput*2000);
                if (transform.position.y < -2) GetComponent<Rigidbody2D>().AddForce(forca * 2);
            } else {
                if (Input.GetKey(KeyCode.Space)) GetComponent<Rigidbody2D>().AddForce(forca);
                if (Input.touchCount == 1) GetComponent<Rigidbody2D>().AddForce(forca);
            }
        }
	}
	void normalizar (){
				GetComponent<Rigidbody2D> ().MovePosition (new Vector2 (posx, transform.position.y+100));
		alert = false;
		//alerttimer = false;
		StopSpawn = false;
		cmmds = false;
        Invoke("preparation", 25f);
		}
}
