using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class DeathZone : NetworkBehaviour {

    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController PlayerController;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Triggered");
            CmdCheckDeathPlayer();
        }
    }

    [Command]
    public void CmdCheckDeathPlayer()
    {
        PlayerController.CmdDie();
    }
}
