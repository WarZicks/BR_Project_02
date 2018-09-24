using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour {

	public Image hpBar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p"))
		{
			hpBar.fillAmount -= 0.33f;
		}
		else if (Input.GetKeyDown("h"))
		{
			hpBar.fillAmount += 0.33f;
		}
	}
}
