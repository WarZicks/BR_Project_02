using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ui_Manager_MM : NetworkBehaviour {
    public GameObject Jouer;
    public GameObject Quitter;
    public GameObject Network;
    public GameObject Retour;
    public GameObject PauseMenu; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
        }
	}
    public void OnClick()
    {
        Jouer.SetActive(false);
        Quitter.SetActive(false);
        Network.SetActive(true);
        Retour.SetActive(true);

    }

    public void OnclickExit()
    {
        Application.Quit();
    }
    public void OnClickReturn()
    {
        Jouer.SetActive(true);
        Quitter.SetActive(true);
        Network.SetActive(false);
        Retour.SetActive(false);

    }

    public void OnClickResume()
    {
        PauseMenu.SetActive(false);
    }
}
