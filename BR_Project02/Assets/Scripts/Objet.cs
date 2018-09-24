using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objet : MonoBehaviour {

    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
        spawnPoint = transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("m"))
        {
            transform.Translate(0f, 0f, 1f);
        }
        
        if(Input.GetKeyDown("r"))
        {
            Respawn();
        }

        if (Input.GetKeyDown("g"))
        {
            Vanish();
        }
    }

    void Respawn ()
    {
        transform.position = spawnPoint;
    }

    void Vanish()
    {
        gameObject.SetActive(false);
    }
}
