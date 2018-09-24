using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefilementTexte : MonoBehaviour {

	public string[] MonTexte;
	public Text ZoneDeTexte;
	private int PhraseIdx = 0;
	private int TextIdx = 0;

	// Use this for initialization
	void Start () {
		ZoneDeTexte.text = "";
		DisplayLetter();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Return) && (TextIdx != MonTexte[PhraseIdx].Length))
		{
			DisplayFullPhrase();
		}
		else if (Input.GetKeyDown(KeyCode.Return) && (TextIdx == MonTexte[PhraseIdx].Length))
		{
			NextPhrase();
		}
	}

	void DisplayFullPhrase ()
	{
		StopCoroutine("TextWait");
		TextIdx = MonTexte[PhraseIdx].Length;
		ZoneDeTexte.text = MonTexte[PhraseIdx];
	}

	void DisplayLetter ()
	{
		if (TextIdx <= MonTexte[PhraseIdx].Length - 1)
		{
			ZoneDeTexte.text += MonTexte[PhraseIdx][TextIdx].ToString();
			StartCoroutine("TextWait");
		}
	}

	IEnumerator TextWait()
	{
		yield return new WaitForSeconds(0.2f);
		TextIdx++;
		DisplayLetter();
	}

	void NextPhrase ()
	{
		PhraseIdx++;
		if (PhraseIdx <= MonTexte.Length - 1)
		{
			TextIdx = 0;
			ZoneDeTexte.text = "";
			DisplayLetter();
		}
	}
}
