using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rarity_", menuName = "New Rarity")]

public class Rarity : ScriptableObject {

    public string rarityName;
    public Color rarityColor;
    public int rarityValue;
    public int rarityDropRate;
    public List<LootItem> rarityItems;
}
