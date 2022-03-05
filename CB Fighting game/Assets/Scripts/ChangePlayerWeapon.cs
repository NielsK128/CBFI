using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerWeapon : MonoBehaviour
{
    public void switchWeapon() {
        GameObject.FindWithTag("Player").GetComponent<EquipWeapon>().SwitchWeapon();
    }
}
