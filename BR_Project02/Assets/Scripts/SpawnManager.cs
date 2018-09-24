using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public GameObject CubeObstacle;
	public GameObject[] Spawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("p"))
		{
			SpawnCube();
		}
	}

	void SpawnCube ()
	{
		int idx = Random.Range(0,3);
		Instantiate(CubeObstacle, Spawn[idx].transform.position, Spawn[idx].transform.rotation);
	}
}
