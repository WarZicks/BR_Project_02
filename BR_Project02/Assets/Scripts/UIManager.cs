using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public string PlayScene;

    private int playerExp = 0;
    public int expLimit;
    private int playerLevel = 1;
    public Image expImage;
    public Text levelText;
    public Text expText;

    private int playerMoney = 0;
    public Text moneyText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {

        }
	}

    public void OnClickMob(int expAmount)
    {
        playerExp += expAmount;
        CheckLevelUp();
        UpdateExpSection();
    }

    public void OnClickChest(int moneyAmount)
    {
        playerMoney += moneyAmount;
        UpdateMoneySection();
    }

    public void UpdateExpSection ()
    {
        expText.text = playerExp.ToString() + " / " + expLimit.ToString();
        expImage.fillAmount = (playerExp * 1.0f) / (expLimit * 1.0f);
        levelText.text = playerLevel.ToString();
    }

    public void UpdateMoneySection ()
    {
        moneyText.text = playerMoney.ToString();
    }

    public void CheckLevelUp ()
    {
        while (playerExp >= expLimit)
        {
            playerLevel += 1;
            playerExp = playerExp - expLimit;
            expLimit += 50;
        }
    }

	public void OnClickplay ()
	{
		SceneManager.LoadScene(PlayScene);
	}

	public void OnClickExit ()
	{
		Application.Quit();
	}
}
