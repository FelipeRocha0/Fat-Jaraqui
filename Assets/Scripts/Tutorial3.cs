using UnityEngine;
using System.Collections;

public class Tutorial3 : MonoBehaviour {
    public Controller Controller;

    void Awake()
    {
        Controller = FindObjectOfType(typeof(Controller)) as Controller;
        Invoke ("retorno", 4f);
    }
    public void retorno()
    {
        gameObject.SetActive(false);
        Controller.Retornar();
    }
}