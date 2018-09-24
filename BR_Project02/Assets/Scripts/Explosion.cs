using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public GameObject Boom;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(Boom, transform.position, transform.rotation);
        }
	}
}
