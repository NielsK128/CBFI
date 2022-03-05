using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CosmeticManager", menuName = "Cosmetic Manager")]
public class CosmeticManager : ScriptableObject
{
    [SerializeField] public Cosmetic[] cosmetics;
    private const string Prefix = "Cosmetic_";
    private const string SelectedCosmetic = "SelectedCosmetic";

    public void SelectCosmetic(int cosmeticIndex) => PlayerPrefs.SetInt(SelectedCosmetic, cosmeticIndex);

    public Cosmetic GetSelectedCosmetic()
    {
        int cosmeticIndex = PlayerPrefs.GetInt(SelectedCosmetic, 0);
        if (cosmeticIndex >= 0 && cosmeticIndex < cosmetics.Length)
        {
            return cosmetics[cosmeticIndex];
        }
        else
        {
            return null;
        }
    }

    public void Unlock(int cosmeticIndex) => PlayerPrefs.SetInt(Prefix + cosmeticIndex, 1);

    public bool IsUnlocked(int cosmeticIndex) => PlayerPrefs.GetInt(Prefix + cosmeticIndex, 0) == 1;
}