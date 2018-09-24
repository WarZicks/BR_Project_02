using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject ObjectToSpawn;
	public GameObject PosToSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f"))
		{
			SpawnObject();
		}
	}

	void SpawnObject ()
	{
		Instantiate(ObjectToSpawn, PosToSpawn.transform.position, PosToSpawn.transform.rotation);
	}
}
