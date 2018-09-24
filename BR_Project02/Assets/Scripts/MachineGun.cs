using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MachineGun : MonoBehaviour {

    public float rayDistance = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate ()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Debug.Log(hit.distance);
            Debug.Log(hit.collider.gameObject.name);
            if (Input.GetMouseButton(0))
            {
                hit.rigidbody.AddForce((hit.transform.position - transform.position).normalized * 10f, ForceMode.Impulse);
            }
        }
    }
}
