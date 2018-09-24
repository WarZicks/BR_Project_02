using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour {

    public List<Rarity> lootRarities;
    private int dropSum = 0;
    private int rarIdx;

    public static LootManager Singleton;

    void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenBox ()
    {
        Debug.Log("Box ouverte !");
    }

    public GameObject PickAnObject ()
    {
        var progressDrop = lootRarities[0].rarityDropRate;

        for (var i = 0; i < lootRarities.Count; i++)
        {
            dropSum += lootRarities[i].rarityDropRate;
        }

        var rndItem = Random.Range(0, dropSum);

        for (var j = 0; j < lootRarities.Count; j++)
        {
            if (rndItem < progressDrop)
            {
                rarIdx = j;
                break;
            }
            else if (rndItem >= progressDrop)
            {
                progressDrop += lootRarities[j+1].rarityDropRate;
            }
        }

        var rndItemInList = Random.Range(0, lootRarities[rarIdx].rarityItems.Count);
        dropSum = 0;
        return lootRarities[rarIdx].rarityItems[rndItemInList].lootPrefab;
    }
}
