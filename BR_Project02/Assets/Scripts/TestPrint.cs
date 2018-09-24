using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPrint : MonoBehaviour {

	public int Valeur;
	private int ValeurDeMonArgent = 502;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown("f"))
		{
			AjouterArgent(Valeur);
		}

		if (Input.GetKeyDown("b"))
		{
			AjouterBeaucoupArgent();
		}
	}

	void AjouterArgent (int moneyAmount) {
		ValeurDeMonArgent += moneyAmount;
		Debug.Log(ValeurDeMonArgent);
	}

	void AjouterBeaucoupArgent ()
	{
		AjouterArgent (900000);
	}
}
