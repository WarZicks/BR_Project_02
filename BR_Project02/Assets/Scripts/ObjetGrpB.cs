using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetGrpB : MonoBehaviour {

    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
        spawnPoint = transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (Input.GetKeyDown("r"))
        {
            Respawn();
        }

        if (Input.GetKeyDown("v"))
        {
            Vanish();
        }
    }

    void Respawn()
    {
        transform.position = spawnPoint;
    }

    void Vanish()
    {
        gameObject.SetActive(false);
    }
}
