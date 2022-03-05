using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWeapon : MonoBehaviour
{
    public List<GameObject> weapons = new List<GameObject>();
    public GameObject activeWeapon;
    public int currentIndex;
    public int size;

    private void Start()
    {
        weapons[0].SetActive(true);
        activeWeapon = weapons[0];
        currentIndex = 0;
    }

    public void SwitchWeapon()
    {
        activeWeapon.SetActive(false);
        if (weapons.Count-1 > currentIndex)
        {
            currentIndex++;
        } else
        {
            currentIndex = 0;
        }
        weapons[currentIndex].SetActive(true);
        activeWeapon = weapons[currentIndex];
    }
}
