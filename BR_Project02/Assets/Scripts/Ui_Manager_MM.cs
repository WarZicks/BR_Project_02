using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ui_Manager_MM : MonoBehaviour {
    public GameObject Jouer;
    public GameObject Quitter;
    public GameObject Network;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        Jouer.SetActive(false);
        Quitter.SetActive(false);
        Network.SetActive(true);
    }

    public void OnclickExit()
    {
        Application.Quit();
    }
}
