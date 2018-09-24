using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    public Image expImage;
    public Text expText;
    public Text levelText;
    public int addedExpPerLevel = 250;

    private int playerExp = 0;
    private int playerLvl = 1;
    private int myMoney;
    public Text moneyText;

    // Use this for initialization
    void Start () {
        UpdateExpDisplay();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddExp (int expAmount)
    {
        playerExp += expAmount;
        while (AmLevelUp())
        {
            LevelUpPlease();
        }
        UpdateExpDisplay();
    }

    public void AddMoney (int moneyAmount)
    {
        myMoney += moneyAmount;
        UpdateMoneyDisplay();
    }

    public void UpdateExpDisplay ()
    {
        expText.text = playerExp.ToString() + "/" + addedExpPerLevel.ToString();
        levelText.text = playerLvl.ToString();
        expImage.fillAmount = (playerExp * 1.0f) / (addedExpPerLevel * 1.0f);
    }

    public void UpdateMoneyDisplay()
    {
        moneyText.text = myMoney.ToString();
    }

    public bool AmLevelUp ()
    {
        return (playerExp >= addedExpPerLevel);
    }

    public void LevelUpPlease ()
    {
        var tooMuchExp = playerExp - addedExpPerLevel;
        addedExpPerLevel += 250;
        playerExp = tooMuchExp;
        playerLvl++;
    }
}
