using UnityEngine;
using System.Collections;

public class TutorialAlerta : MonoBehaviour {
    public GameObject warning;
    public GameObject tutorial2;
    public static int oneshot = 0;
    public Controller Controller;

    void Awake ()
    {
        Controller = FindObjectOfType(typeof(Controller)) as Controller;
        Invoke("transicao", 8f);
        tutorial2.SetActive(false);
        warning.SetActive(true);
    }
    void transicao()
    {   
        warning.SetActive(false);
        if (oneshot == 0) { tutorial2.SetActive(true); }
        else { Controller.alerta(); }
    }
}
