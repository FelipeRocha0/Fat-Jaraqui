using UnityEngine;
using System.Collections;

public class Tutorial2 : MonoBehaviour {
    public Controller Controller;

    void Awake()
    {
        Controller = FindObjectOfType(typeof(Controller)) as Controller;
    }
    public void Tutorialclick ()
    {
        TutorialAlerta.oneshot = 1;
        gameObject.SetActive(false);
        Controller.alerta();
    }
}
